using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAprilChallenge
{
    public class Day10
    {
        private int[] stack = new int[7500];
        private int[] minStack = new int[7500];
        private int current = 0;

        /** initialize your data structure here. */
        public MinStack()
        {
            for (var i = 0; i < minStack.Length; i++)
            {
                minStack[i] = int.MaxValue;
            }
        }

        public void Push(int x)
        {
            if (current == 0)
            {
                minStack[current] = x;
            }
            else if (x < minStack[current - 1])
            {
                minStack[current] = x;
            }
            else
            {
                minStack[current] = minStack[current - 1];
            }
            stack[current++] = x;
        }

        public void Pop() => minStack[--current] = int.MaxValue;

        public int Top() => stack[current - 1];
 

        public int GetMin() => minStack[current - 1];

    }
}
