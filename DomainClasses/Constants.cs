using System.Collections.Generic;

namespace SimpletronVisual.DomainClasses
{
    public class Constants
    {
        public static Dictionary<int, string> InstructionDescription = new Dictionary<int, string> {
            { 10, "Read a number from the terminal into a specific location in memory" },
            { 11, "Write a number from a specific location in memory to the terminal" },
            { 20, "Load a number from a specific location in memory into the accumulator" },
            { 21, "Store a number from the accumulator into a specific location in memory" },
            { 30, "Add a number from a specific location in memory to the number in the accumulator (leave result in accumulator)" },
            { 31, "Subtract a number from a specific location in memory from the number in the accumulator (leave result in accumulator)" },
            { 32, "Divide a number from an accumulator into the number in the specific location in memory (leave result in accumulator)" },
            { 33, "Multiply a number from a specific location in memory by the number in the accumulator (leave result in accumulator)" },
            { 40, "Branch to a specific location in memory" },
            { 41, "Branch to a specific location in memory if the accumulator is negative" },
            { 42, "Branch to a specific location in memory if the accumulator is zero" },
            { 43, "Halt — i.e., the program has completed its task" },
        };
    }
}
