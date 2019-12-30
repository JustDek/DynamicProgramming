using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    class UglyNumbers
    {
        public static int GetNthNumber(int n)
        {
            int[] uglyNums = new int[n];
            uglyNums[0] = 1;
            int ptr2 = 0, ptr3 = 0, ptr5 = 0;
            int NextMultipleOf2 = uglyNums[ptr2] * 2;
            int NextMultipleOf3 = uglyNums[ptr3] * 3;
            int NextMultipleOf5 = uglyNums[ptr5] * 5;

            for (int i = 1; i < n; i++)
            {
                int NextUglyNum = Math.Min(NextMultipleOf2,
                    Math.Min(NextMultipleOf3, NextMultipleOf5));

                uglyNums[i] = NextUglyNum;

                if (NextUglyNum == NextMultipleOf2)
                {
                    ptr2++;
                    NextMultipleOf2 = uglyNums[ptr2] * 2;
                }
                if (NextUglyNum == NextMultipleOf3)
                {
                    ptr3++;
                    NextMultipleOf3 = uglyNums[ptr3] * 3;
                }
                if (NextUglyNum == NextMultipleOf5)
                {
                    ptr5++;
                    NextMultipleOf5 = uglyNums[ptr5] * 5;
                }
            }

            return uglyNums[n-1];
        }

    }
}
