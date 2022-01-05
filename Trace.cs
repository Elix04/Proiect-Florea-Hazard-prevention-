using System;

namespace Proiect_Florea__Hazard_prevention_
{
    public enum TraceType
    {
        Arithmetic = 0,
        Branch = 1,
        Store = 2,
        Load = 3
    }

    public class Trace
    {
        public string FULL { get; }

        public TraceType TYPE { get; }

        public int CURRENT_ADDRESS { get; }

        public int? DESTINATION_ADDRESS { get; }

        public Trace(string traceString)
        {
            var splitTrace = traceString.Split(' ');
            var type = DetermineTraceType(splitTrace[0]);

            FULL = traceString;
            TYPE = type;
            CURRENT_ADDRESS = Convert.ToInt32(splitTrace[1]);

            if (splitTrace[2] != "XXXX")
            {
                DESTINATION_ADDRESS = Convert.ToInt32(splitTrace[2]);
            }
        }

        private static TraceType DetermineTraceType(string typeString)
        {
            TraceType type;

            switch (typeString)
            {
                case "A":
                    type = TraceType.Arithmetic;
                    break;
                case "B":
                    type = TraceType.Branch;
                    break;
                case "S":
                    type = TraceType.Store;
                    break;
                case "L":
                    type = TraceType.Load;
                    break;
                default:
                    throw new ArgumentException("Invalid type");
            }

            return type;
        }

        public bool IsOfType(TraceType type) => TYPE == type;

        public override string ToString()
        {
            return FULL;
        }
    }
}