using System;

namespace Generics_Problem_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Float Value");
            float floatMaxValue = CheckMaxFloatValue.MaxFloatValue(43.5f, 98.4f, 10.23f);
            Console.WriteLine("Maximum Float Value is :: " + floatMaxValue);
        }
    }
}
