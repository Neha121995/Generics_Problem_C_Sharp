﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Problem_C_Sharp
{
    class CheckMaxIntValue
    {
        public static int MaximumIntValue(int fValue, int sValue, int tValue)
        {
            if (fValue.CompareTo(sValue) > 0 && fValue.CompareTo(tValue) > 0)
            {
                return fValue;
            }
            if (sValue.CompareTo(fValue) > 0 && sValue.CompareTo(tValue) > 0)
            {
                return sValue;
            }
            if (tValue.CompareTo(fValue) > 0 && tValue.CompareTo(sValue) > 0)
            {
                return tValue;
            }
            throw new Exception("FirstValue,SecondValue and ThirdValue Are Same");
        }
    }
}
