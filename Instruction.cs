public class Instruction
{
    public string FULL { get; }

    public string MNEMONIC { get; }

    public string DESTINATION { get; }

    public string SOURCE1 { get; }

    public string SOURCE2 { get; }

    public Instruction(string instruction)
    {
        var splitInstruction = instruction.Split(' ');

        FULL = instruction;
        MNEMONIC = splitInstruction[0].Trim();
        DESTINATION = splitInstruction[1].Replace(",", "").Trim();

        if (splitInstruction.Length > 2)
        {
            SOURCE1 = splitInstruction[2].Replace(",", "").Trim();
        }

        if (splitInstruction.Length >= 3)
        {
            SOURCE2 = splitInstruction.Length == 4 ? splitInstruction[3].Trim() : null;
        }
    }

    public override string ToString()
    {
        return FULL;
    }
}
