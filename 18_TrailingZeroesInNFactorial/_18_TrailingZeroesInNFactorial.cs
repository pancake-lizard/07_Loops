using System;
using System.Numerics;

class _18_TrailingZeroesInNFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        int trailingZeroes = 0;
        int sum = 5;

        while (n >= sum)
        {
            trailingZeroes += (n / sum);
            sum *= 5;
        }
        Console.WriteLine("{0}", trailingZeroes);
    }
}

