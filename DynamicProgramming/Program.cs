using System;
using DynamicProgramming.Backtracking;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            NQueensProblem qn = new NQueensProblem();
            qn.QNSolution(10);
        }
    }
}
