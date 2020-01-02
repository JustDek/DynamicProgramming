using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming.Backtracking
{
    public class NQueensProblem
    {   
        private void printSolution(int[,] board, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private bool solve(int[,] board, int col, int n) 
        {
            if (col >= n)
            {
                return true;
            }
            
            for (int i = 0; i < n; i++)
            {
                if (isSafe(board, i, col, n))
                {
                    board[i, col] = 1;

                    if (solve(board, col + 1, n) == true)
                    {
                        return true;
                    }

                    board[i, col] = 0;
                }
            }

            return false;
        }

        private bool isSafe(int[,] board, int row, int col, int n)
        {

            for (int i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                {
                    return false;
                } 
            }

            for (int i = row, j = col; i >= 0 && j >=0; i--, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            for (int i = row, j = col; i < n && j >= 0; i++, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            return true;
        }
        public void QNSolution(int n)
        {
            int count = 0;
            int[,] board = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = 0;
                }

            if (solve(board, 0, n) == false)
            {
                Console.WriteLine("There is no solution");
                return;
            }

            printSolution(board, n);

        }
    }
}
