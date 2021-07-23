using System;

namespace Generics_Problem_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Generics_UsingMaxCount<int> intValue = new Generics_UsingMaxCount<int>(76, 54, 87, 12, 78, 20, 89, 13);
            intValue.threeIFSMaxValues();
            Generics_UsingMaxCount<float> floatValue = new Generics_UsingMaxCount<float>(56.8f, 12.0f, 30.34f, 23.90f, 67.23f, 34.89f, 34.90f, 108.90f, 20.30f);
            floatValue.threeIFSMaxValues();
            Generics_UsingMaxCount<string> stringValue = new Generics_UsingMaxCount<string>("Neha", "Karan", "Ruturaj", "Sandip", "Shivani");
            stringValue.threeIFSMaxValues();
        }
    }
}
