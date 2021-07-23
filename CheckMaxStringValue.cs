using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Problem_C_Sharp
{
    class CheckMaxStringValue
    {
        public static string MaxStringNumber(string fString, string sString, string tString)
        {
            if (fString.CompareTo(sString) > 0 && fString.CompareTo(tString) > 0 ||
                fString.CompareTo(sString) >= 0 && fString.CompareTo(tString) > 0 ||
                fString.CompareTo(sString) > 0 && fString.CompareTo(tString) >= 0)
            {
                return fString;
            }

            if (sString.CompareTo(fString) > 0 && sString.CompareTo(tString) > 0 ||
                sString.CompareTo(fString) >= 0 && sString.CompareTo(tString) > 0 ||
                sString.CompareTo(fString) > 0 && sString.CompareTo(tString) >= 0)
            {
                return sString;
            }

            if (tString.CompareTo(fString) > 0 && tString.CompareTo(sString) > 0 ||
                tString.CompareTo(fString) >= 0 && tString.CompareTo(sString) > 0 ||
                tString.CompareTo(fString) > 0 && tString.CompareTo(sString) >= 0)
            {
                return tString;
            }

            throw new Exception("FirstStringValue,SecondStringValue and ThirdStringValue Are Same");
        }
    }
}
