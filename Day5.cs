﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAprilChallenge
{
    public class Day5
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;
            var buyPrice = -1;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if ( buyPrice == -1 && prices[i] < prices[i + 1])
                {
                    buyPrice = prices[i];
                }
                else if (buyPrice != -1 && prices[i] > prices[i+1])
                {
                    profit += prices[i] - buyPrice;
                    buyPrice = -1;
                }
            }
            if (buyPrice != -1)
            {
                profit += prices[prices.Length - 1] - buyPrice;
            }
            return profit;
        }
    }
}
