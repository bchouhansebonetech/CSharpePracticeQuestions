using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class StringReverse
    {
        public string getReversedString(string str)
        {
            int right = str.Length - 1;
            string resultStr = "";

            while (right >= 0)
            {
                resultStr += str[right];
                right--;
            }
            return resultStr;
        }
    }
}
