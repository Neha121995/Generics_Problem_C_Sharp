using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Problem_C_Sharp
{
    class Generics_UsingMaxCount<T> where T : IComparable<T>
    {
        List<T> maxValue = new List<T>();
        public Generics_UsingMaxCount(params T[] values)
        {
            this.ValuesBuilder(values);
        }
        public void ValuesBuilder(T[] maxValue)
        {
            foreach (T element in maxValue)
            {
                this.maxValue.Add(element);
            }
        }
        public void threeIFSMaxValues()
        {
            this.maxValue.Sort();
            Console.WriteLine(this.maxValue[this.maxValue.Count - 1]);
        }
    }
}