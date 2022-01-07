using System.Collections.Generic;
using System.Linq;

public class ImmediateMerging : InstructionFix
{
    private static int LINE_GAP { get; } = 1;

    private readonly string[] allowedCombinations = new string[]
    {
            "MULT - ADD",
            "ADD - AND"
    };

    protected bool ImproveCode(List<MegaInstruction> instructions)
    {
        if (instructions.Count == 1)
        {
            return false;
        }

        for (var index = 0; index < instructions.Count - 1; index++)
        {
            var instructionOne = instructions[index].Instruction;
            var instructionTwo = instructions[index + 1].Instruction;

            if (instructionOne.SOURCE2 == null || instructionTwo.SOURCE2 == null ||
                !instructionOne.SOURCE2.Contains("#") || !instructionTwo.SOURCE2.Contains("#"))
            {
                continue;
            }

            if (instructionOne.DESTINATION == instructionTwo.SOURCE1)
            {
                if (InstructionUtil.IsLoadOrStoreInstruction(instructionTwo.FULL) ||
                    InstructionUtil.IsLoadOrStoreInstruction(instructionOne.FULL))
                {
                    continue;
                }

                var mnemonicInstructionOne = instructionOne.MNEMONIC;
                var mnemonicInstructionTwo = instructionTwo.MNEMONIC;
                var combination = $"{mnemonicInstructionOne} - {mnemonicInstructionTwo}";

                if (allowedCombinations.Contains(combination))
                {
                    continue;
                }

                if ((mnemonicInstructionOne == "DIV" && mnemonicInstructionTwo == "MULT") ||
                    (mnemonicInstructionOne == "MULT" && mnemonicInstructionTwo == "DIV"))
                {
                    if (instructionOne.SOURCE2 == instructionTwo.SOURCE2)
                    {
                        var instructionLine = instructions[index].Line;
                        var indexOfLine = instructionLine - 1;
                        AssemblyLines.RemoveRange(indexOfLine, 2);
                        var newInstruction = $"MOV {instructionTwo.SOURCE1}, {instructionOne.SOURCE1}";
                        AssemblyLines.Insert(indexOfLine, newInstruction);

                        return true;
                    }
                }

                var x = 1 == 1;
            }
        }

        return false;
    }

    public ImmediateMerging(List<string> assemblyLines, List<Trace> originalTracesLines)
        : base(assemblyLines, originalTracesLines)
    {

    }
}
