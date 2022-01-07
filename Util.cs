using System.Linq;
    public static class Util
    {
        private static readonly string[] AllowedImmediateMergingCombinations =
        {
            "MULT - ADD",
            "ADD - AND",
            "ASL - ASR",
            "ASR - ASL"
        };

        private static readonly string[] AllowedMovMergingCombinations =
        {
            "MOV - ST",
        };

        public static bool CanApplyMovMerging(MegaInstruction megaInstructionOne, MegaInstruction megaInstructionTwo)
        {
            var instructionOne = megaInstructionOne.Instruction;
            var instructionTwo = megaInstructionTwo.Instruction;

            if (instructionOne.MNEMONIC == "MOV")
            {
                if (InstructionUtil.IsLoadOrStoreInstruction(instructionTwo.FULL))
                {
                    // TODO: FIGURE SHIT OUT
                    if (instructionTwo.MNEMONIC == "ST" && instructionTwo.SOURCE1 == instructionOne.DESTINATION)
                    {
                        return true;
                    }

                    return false;
                }

                // TODO: take into account Source2 is null
//                if (instructionOne.DESTINATION == instructionTwo.SOURCE1)
//                {
//                    return true;
//                }
//                if(instructionOne.D)
                return new[] {instructionTwo.SOURCE1, instructionTwo.SOURCE2}.Contains(instructionOne.DESTINATION);
            }

            return false;
        }

        public static bool CanApplyImmediateMerging(MegaInstruction megaInstructionOne, MegaInstruction megaInstructionTwo)
        {
            var instructionOne = megaInstructionOne.Instruction;
            var instructionTwo = megaInstructionTwo.Instruction;

            if (instructionOne.SOURCE2 == null || instructionTwo.SOURCE2 == null ||
                !instructionOne.SOURCE2.StartsWith("#") || !instructionTwo.SOURCE2.StartsWith("#"))
            {
                return false;
            }

            if (InstructionUtil.IsLoadOrStoreInstruction(instructionTwo.FULL) ||
                InstructionUtil.IsLoadOrStoreInstruction(instructionOne.FULL))
            {
                return false;
            }

            var combination = GenerateMnemonicCombination(instructionOne, instructionTwo);

            if (AllowedImmediateMergingCombinations.Contains(combination))
            {
                return false;
            }

            return instructionOne.DESTINATION == instructionTwo.SOURCE1;
        }

        public static bool CanApplyMovReabsorption(MegaInstruction megaInstructionOne, MegaInstruction megaInstructionTwo)
        {
            var instructionOne = megaInstructionOne.Instruction;
            var instructionTwo = megaInstructionTwo.Instruction;

            if (instructionTwo.MNEMONIC == "MOV")
            {
                return instructionOne.DESTINATION == instructionTwo.SOURCE1;
            }

            return false;
        }

        public static bool CanApplyMemoryAntiAlias(MegaInstruction megaInstructionOne, MegaInstruction megaInstructionTwo)
        {
            var instructionOne = megaInstructionOne.Instruction;
            var instructionTwo = megaInstructionTwo.Instruction;

            var areDestinationAddressesEqual = AreDestinationAddressesEqual(megaInstructionOne, megaInstructionTwo);


            if (instructionOne.MNEMONIC == "ST" && instructionTwo.MNEMONIC == "LD")
            {
                return areDestinationAddressesEqual || instructionOne.DESTINATION == instructionTwo.SOURCE1;
            }
            else if (instructionOne.MNEMONIC == "LD" && instructionTwo.MNEMONIC == "ST")
            {
                // TODO ADD CODE TO HANDLE THIS
                return areDestinationAddressesEqual || false;
            }

            return false;
        }

        private static bool AreDestinationAddressesEqual(MegaInstruction megaInstructionOne, MegaInstruction megaInstructionTwo)
        {
            var traceOne = megaInstructionOne.Trace;
            var traceTwo = megaInstructionTwo.Trace;

            if (traceOne != null && traceTwo != null)
            {
                if (traceOne.DESTINATION_ADDRESS != null && traceTwo.DESTINATION_ADDRESS != null)
                    return traceOne.DESTINATION_ADDRESS == traceTwo.DESTINATION_ADDRESS;
            }

            return false;
        }

        private static string GenerateMnemonicCombination(Instruction instructionOne, Instruction instructionTwo)
        {
            var mnemonicInstructionOne = instructionOne.MNEMONIC;
            var mnemonicInstructionTwo = instructionTwo.MNEMONIC;
            var combination = $"{mnemonicInstructionOne} - {mnemonicInstructionTwo}";

            return combination;
        }
    }