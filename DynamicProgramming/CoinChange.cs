using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class CoinChange
    {
        public static int MinimumCoinsToChange(int[] coins, int money)
        {
            int[] ChangeTable = new int[money + 1];
            ChangeTable[0] = 0;

            for (int i = 1; i <= money; i++)
            {
                foreach (int coin in coins)
                {
                    if (coin <= i)
                    {
                        ChangeTable[i] = ChangeTable[i - coin] + 1;
                    }
                }
            }

            return ChangeTable[money];
        }

    }
}
