using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeAprilChallenge
{
    class Day3
    {
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int currentMax = nums[0];

            foreach (var item in nums.Skip(1))
            {
                if (currentMax > 0)
                {
                    currentMax += item;
                }
                else
                {
                    currentMax = item;
                }
                if (currentMax > max)
                {
                    max = currentMax;
                }
            }

            return max;
        }
    }
}
