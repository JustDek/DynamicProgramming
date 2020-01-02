using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    class CoinChange
    {
        public static int MinimumCoinsToChange(int[] coins, int money)
        {
            int max = money + 1;

            int[] ChangeTable = new int[money + 1];
            ChangeTable[0] = 0;

            for (int i = 1; i <= money; i++)
            {
                ChangeTable[i] = max;
            }

            for (int i = 1; i <= money; i++)
            {
                foreach (int coin in coins)
                {
                    if (coin <= i)
                    {
                        ChangeTable[i] = Math.Min(ChangeTable[i], ChangeTable[i - coin] + 1);
                    }
                }
            }

            return ChangeTable[money] > money ? -1 : ChangeTable[money];
        }

    }
}
