using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int num)
        {
            if (thisObj.Length <= num)
                return thisObj;

            else
                return thisObj.Substring(0, num) + "...";
        }
    }
}
