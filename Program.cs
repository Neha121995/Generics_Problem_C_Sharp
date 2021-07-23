using System;

namespace Generics_Problem_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Integer Value");
            int maxIntValue = CheckMaxIntValue.MaximumIntValue(87, 23, 45);
            Console.WriteLine("Maximum Value :: " + maxIntValue);
        }
    }
}
