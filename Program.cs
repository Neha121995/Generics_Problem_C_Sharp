using System;

namespace Generics_Problem_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Float Value");
            string maxStringValue = CheckMaxStringValue.MaxStringNumber("Neha", "Nikita", "Karan");
            Console.WriteLine("Maximum String Value is :: " + maxStringValue);
        }
    }
}
