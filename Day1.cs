using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAprilChallenge
{
    class Day1
    {
        public int SingleNumber(int[] nums)
        {
            int res = 0;
            foreach (var num in nums)
            {
                res ^= num;
            }

            return res;
        }
    }
}
