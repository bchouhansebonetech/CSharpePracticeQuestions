using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class CheckingPrime
    {
        public bool isPrime(int num)
        {
            if (num == 0)
                return false;

            int count = 0;

            for (int iterator = 1; iterator < num / 2; iterator++)
            {
                if (num % iterator == 0)
                    count++;
            }

            if (count > 1)
                return false;

            return true;
        }
    }
}
