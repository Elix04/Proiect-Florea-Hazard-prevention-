using System.Collections.Generic;
using System.Diagnostics;

namespace Proiect_Florea__Hazard_prevention_
{
    internal class ReArrange
    {
        protected readonly List<string> AssemblyLines;
        private readonly List<Trace> originalTracesLines;

        private static int LINE_GAP { get; } = 1;
        private static int MAX_INSTRUCTIONS_IN_PIPELINE { get; } = 4;

        private List<string> handledLines = new List<string>();

        protected ReArrange(List<string> assemblyLines, List<Trace> originalTracesLines)
        {
            this.AssemblyLines = assemblyLines;
            this.originalTracesLines = originalTracesLines;
        }

        public List<string> Rearrange()
        {
          
            var builder = new MegaBlockBuilder();
            var megaInstructions = builder.Build(AssemblyLines, originalTracesLines);

            for (var index = 0; index < megaInstructions.Count - 1; index++)
            {
                var megaInstructionOne = megaInstructions[index];
                var megaInstructionTwo = megaInstructions[index + 1];

                if (handledLines.Contains(megaInstructionOne.ToString()))
                {
                    continue;
                }

                if (Util.CanApplyImmediateMerging(megaInstructionOne, megaInstructionTwo))
                {
                    ApplyImmediateMerging(megaInstructionOne, megaInstructionTwo);
                    handledLines.Add(megaInstructionOne.ToString());
                }

                if (Util.CanApplyMovMerging(megaInstructionOne, megaInstructionTwo))
                {
                    
                    ApplyMovMerging(megaInstructionOne, megaInstructionTwo);
                    handledLines.Add(megaInstructionOne.ToString());
                }

                if (Util.CanApplyMovReabsorption(megaInstructionOne, megaInstructionTwo))
                {
                    ApplyMovReabsorption(megaInstructionOne, megaInstructionTwo);
                    handledLines.Add(megaInstructionOne.ToString());
                }

                if (Util.CanApplyMemoryAntiAlias(megaInstructionOne, megaInstructionTwo))
                {
                  
                    handledLines.Add(megaInstructionOne.ToString());
                }
            }

            return AssemblyLines;
        }

        private void ApplyMovReabsorption(MegaInstruction megaInstructionOne, MegaInstruction megaInstructionTwo)
        {
            var instructionOne = megaInstructionOne.Instruction;
            var instructionTwo = megaInstructionTwo.Instruction;

            var instructionLine = megaInstructionTwo.Line;
            var indexOfLine = instructionLine - 1;
            AssemblyLines.RemoveRange(indexOfLine, 1);
            var mergedInstruction = GenerateNewMovReabsorptionInstruction(instructionTwo, instructionOne);
            AssemblyLines.Insert(indexOfLine, mergedInstruction);
        }

        private string GenerateNewMovReabsorptionInstruction(Instruction instructionTwo, Instruction instructionOne)
        {
            var sb = new StringBuilder();
            sb.Append(instructionOne.MNEMONIC);
            sb.Append(" ");
            sb.Append(instructionTwo.DESTINATION);
            sb.Append(", ");
            sb.Append(instructionOne.SOURCE1);
            sb.Append(", ");
            sb.Append(instructionOne.SOURCE2);
            var mergedInstruction = sb.ToString();
            return mergedInstruction;
        }

        private void ApplyMovMerging(MegaInstruction megaInstructionOne, MegaInstruction megaInstructionTwo)
        {
            var instructionOne = megaInstructionOne.Instruction;
            var instructionTwo = megaInstructionTwo.Instruction;

            /**TODO:
             *  - instructiune relationala
             *  - instructiune gardata
            **/
            var mergedInstruction = instructionTwo.MNEMONIC switch
            {
                "ADD" => GenerateNewMovMergingInstruction(instructionTwo, instructionOne),
                "ST" => GenerateNewStMovMergingInstruction(instructionOne, instructionTwo),
                _ => ""
            };

            if (mergedInstruction != "")
            {
                var instructionLine = megaInstructionTwo.Line;
                var indexOfLine = instructionLine - 1;
                AssemblyLines.RemoveRange(indexOfLine, 1);
                AssemblyLines.Insert(indexOfLine, mergedInstruction);
            }
        }

        private string GenerateNewStMovMergingInstruction(Instruction instructionOne, Instruction instructionTwo)
        {
            if (instructionOne.DESTINATION == instructionTwo.SOURCE1)
            {
                if (instructionOne.SOURCE1.StartsWith("#") && instructionOne.SOURCE1 != "#0")
                {
                    return "";
                }

                var source1 = instructionOne.SOURCE1 == "#0" ? "R0" : instructionOne.SOURCE1;
                return $"{instructionTwo.MNEMONIC} {instructionTwo}, {source1}";
            }

            if (instructionTwo.DESTINATION.Contains(instructionOne.DESTINATION))
            {
                string newInstruction;
                if (instructionOne.SOURCE1 == "#0")
                {
                    newInstruction = instructionTwo.FULL.Replace(instructionOne.DESTINATION, "R0");
                }
                else
                {
                    newInstruction = instructionTwo.FULL.Replace(instructionOne.DESTINATION, instructionOne.SOURCE1);
                }

                return newInstruction;
            }

            return "";
        }

        private static string GenerateNewMovMergingInstruction(Instruction instructionTwo, Instruction instructionOne)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(instructionTwo.MNEMONIC);
            stringBuilder.Append(" ");
            stringBuilder.Append(instructionTwo.DESTINATION);
            stringBuilder.Append(", ");

            stringBuilder.Append(instructionOne.DESTINATION == instructionTwo.SOURCE1
                ? instructionOne.SOURCE1
                : instructionTwo.SOURCE1);

            stringBuilder.Append(", ");

            stringBuilder.Append(instructionOne.DESTINATION == instructionTwo.SOURCE2
                ? instructionOne.SOURCE1
                : instructionTwo.SOURCE2);

            var mergedInstruction = stringBuilder.ToString();

            return mergedInstruction;
        }

        private void ApplyImmediateMerging(MegaInstruction megaInstructionOne, MegaInstruction megaInstructionTwo)
        {
            var instructionOne = megaInstructionOne.Instruction;
            var instructionTwo = megaInstructionTwo.Instruction;

            var mnemonicInstructionOne = instructionOne.MNEMONIC;
            var mnemonicInstructionTwo = instructionTwo.MNEMONIC;

            if ((mnemonicInstructionOne == "DIV" && mnemonicInstructionTwo == "MULT") ||
                (mnemonicInstructionOne == "MULT" && mnemonicInstructionTwo == "DIV"))
            {
                if (instructionOne.SOURCE2 == instructionTwo.SOURCE2)
                {
                    var instructionLine = megaInstructionOne.Line;
                    var indexOfLine = instructionLine - 1;
                    AssemblyLines.RemoveRange(indexOfLine, 2);
                    var newInstruction = $"MOV {instructionTwo.SOURCE1}, {instructionOne.SOURCE1}";
                    AssemblyLines.Insert(indexOfLine, newInstruction);
                    AssemblyLines.Insert(indexOfLine + 1, "");
                }
            }

            var additionMnemonics = new string[] { "ADD", "SUB" };
            if (additionMnemonics.Contains(mnemonicInstructionOne) && additionMnemonics.Contains(mnemonicInstructionTwo))
            {
                var source2InstructionOne = Convert.ToInt32(instructionOne.SOURCE2.Remove(0, 1));
                var source2InstructionTwo = Convert.ToInt32(instructionOne.SOURCE2.Remove(0, 1));

                source2InstructionOne *= mnemonicInstructionOne == "SUB" ? -1 : 1;
                source2InstructionTwo *= mnemonicInstructionTwo == "SUB" ? -1 : 1;

                var newValue = source2InstructionOne + source2InstructionTwo;
                var newInstruction = $"{instructionTwo.MNEMONIC} {instructionTwo.DESTINATION}, {instructionOne.SOURCE1}, #{newValue}";

                var instructionLine = megaInstructionTwo.Line;
                var indexOfLine = instructionLine - 1;

                AssemblyLines.RemoveRange(indexOfLine, 1);
                AssemblyLines.Insert(indexOfLine, newInstruction);
            }
        }
    }
}