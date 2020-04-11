using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAprilChallenge
{
    public class Day7
    {
        public int CountElements(int[] arr)
        {
            var frequency = new HashSet<int>(arr);
            var output = 0;

            foreach (var item in arr)
            {
                if (frequency.Contains(item + 1))
                {
                    output += 1;
                }
            }

            return output;
        }
    }
}
