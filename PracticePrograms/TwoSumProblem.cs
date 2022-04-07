using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class TwoSumProblem
    {
        public bool isTargetSumAvailable(int[] nums, int k)
        {
            var numsMap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (numsMap.ContainsKey(num))
                    return true;
                else if (!numsMap.ContainsKey(k - num))
                    numsMap.Add(k - num, 0);
            }

            return false;
        }
    }
}
