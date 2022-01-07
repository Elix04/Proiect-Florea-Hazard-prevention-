    public class MegaInstruction
    {
        public int Line { get; }
        public Instruction Instruction { get; }
        public Trace Trace { get; }

        public MegaInstruction(int line, string stringInstruction, string trace)
        {
            Line = line;
            Instruction = new Instruction(stringInstruction);
            Trace = new Trace(trace);
        }

        public MegaInstruction(int line, string stringInstruction, Trace trace)
        {
            Line = line;
            Instruction = new Instruction(stringInstruction);
            Trace = trace;
        }

        public override string ToString()
        {
            return $"{Line}: {Trace.ToString()} - {Instruction.ToString()}";
        }
    }
