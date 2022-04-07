using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class AnagramStrings
    {
        public bool isAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            int[] charCount = new int[26];

            for (int iterator = 0; iterator < str1.Length; iterator++)
                charCount[str1[iterator] - 'a']++;

            for (int iterator = 0; iterator < str1.Length; iterator++)
                charCount[str2[iterator] - 'a']--;

            for (int iterator = 0; iterator < 26; iterator++)
                if (charCount[iterator] != 0)
                    return false;

            return true;
        }
    }
}
