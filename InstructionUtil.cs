namespace Proiect_Florea__Hazard_prevention_
{
    internal class InstructionUtil
    {

        private static readonly string[] BranchMnemonics = new string[] { "BT", "BF", "BSR", "BRA" };

        private static readonly InstructionType[] LoadStoreInstructionTypes =
            new InstructionType[] { InstructionType.Load, InstructionType.Store };

        public static bool IsBranchInstructionWithLabel(string instruction) => BranchMnemonics.Any(instruction.Contains);
        public static bool IsTrap(string instruction) => instruction.Contains("TRAP");
        public static bool IsBsrBranch(string instruction) => instruction.Contains("BSR");
        public static bool IsMovBranchInstruction(string instruction) => instruction.Contains("MOV PC");
        public static bool IsLoadOrStoreInstruction(string instruction) => LoadStoreInstructionTypes.Contains(TypeOf(instruction));

        public static bool IsLabelCommentOrEmptyString(string instruction)
        {
            if (instruction.Contains("/*"))
            {
                return true;
            }

            if (instruction.Contains(":"))
            {
                return true;
            }

            if (instruction.Length == 0)
            {
                return true;
            }

            return false;
        }

        public static InstructionType TypeOf(string instruction)
        {
            var mnemonic = instruction.Split(" ")[0];
            if (mnemonic.Contains("LD"))
            {
                return InstructionType.Load;
            }

            if (mnemonic.Contains("ST"))
            {
                return InstructionType.Store;
            }

            var branches = new string[] { "BT", "BF", "BSR", "TRAP", "BRA" };
            if (branches.Any(branch => branch.Contains(mnemonic)))
            {
                return InstructionType.Branch;
            }

            if (instruction.Contains("MOV PC"))
            {
                return InstructionType.Branch;
            }

            return InstructionType.Arithmetic;
        }

        public static string GetLabelFromBranchInstruction(string instruction)
        {
            var splitInstruction = instruction.Split(" ");

            return splitInstruction[0] == "BRA" ? splitInstruction[1] : splitInstruction[2];
        }
    }

    public enum InstructionType
    {

        Arithmetic = 0,
        Branch = 1,
        Store = 2,
        Load = 3
    }
}