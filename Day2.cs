using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAprilChallenge
{
    public class Day2
    {
        public bool IsHappy(int n)
        {
            int power = 0;
            int tmp = 0;
            var seenNumbers = new HashSet<int>();
            while (n > 1)
            {
                tmp = n;
                int p = 0;
                while(tmp > 0)
                {
                    power = tmp % 10;
                    tmp /= 10;

                    p += power * power;
                }

                if (seenNumbers.Contains(p))
                {
                    return false;
                }

                seenNumbers.Add(p);
                n = p;
            }

            return n == 1;
        }
    }
}
