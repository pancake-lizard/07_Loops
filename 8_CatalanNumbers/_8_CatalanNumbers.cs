using System;
using System.Numerics;

class _8_CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        BigInteger denominator = 1;
        for (int i = 2 * n; i >= n + 2; i--)
        {
            numerator *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            denominator *= i;
        }
        BigInteger catalanNumber = numerator / denominator;

        Console.WriteLine(catalanNumber);
    }
}

