using System;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UglyNumbers.GetNthNumber(150));
            Console.WriteLine(CatalanNumbers.GetCatalanNumber(9));
            Console.WriteLine(CoinChange.MinimumCoinsToChange(new int[] { 1, 2, 5 }, 50));
        }
    }
}
