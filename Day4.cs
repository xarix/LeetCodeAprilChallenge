using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAprilChallenge
{
    public class Day4
    {
        public void MoveZeroes(int[] nums)
        {

            var zero = 0;
            var one = 0;
            int tmp;
            while (zero < nums.Length && one < nums.Length)
            {
                while (zero < nums.Length && nums[zero] != 0)
                {
                    zero++;
                }
                while (one < nums.Length && nums[one] == 0)
                {
                    one++;
                }
                if (one < nums.Length && zero < nums.Length && one > zero)
                {
                    tmp = nums[zero];
                    nums[zero] = nums[one];
                    nums[one] = tmp;
                }
                else
                {
                    one++;
                }
            }
        }
    }
}
