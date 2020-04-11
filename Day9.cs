using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAprilChallenge
{
    public class Day9
    {
        public bool BackspaceCompare(string S, string T)
        {
            var stackA = new Stack<int>();
            var stackB = new Stack<int>();

            foreach (var c in S)
            {
                if (c == '#')
                {
                    if (stackA.Count > 0)
                    {
                        stackA.Pop();
                    }
                }
                else
                {
                    stackA.Push(c);
                }
            }
            foreach (var c in T)
            {
                if (c == '#')
                {
                    if (stackB.Count > 0)
                    {
                        stackB.Pop();
                    }
                }
                else
                {
                    stackB.Push(c);
                }
            }

            while (stackA.Count > 0 && stackB.Count > 0)
            {
                if (stackA.Pop() != stackB.Pop())
                {
                    return false;
                }
            }
            if (stackA.Count > 0 || stackB.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
