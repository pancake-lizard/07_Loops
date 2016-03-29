using System;
using System.Numerics;

class _7_NumberOfCombinations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                factorialK *= i;
            }
            factorialN *= i;
        }

        for (int i = 1; i <= n - k; i++)
        {
            factorialNK *= i;
        }

        BigInteger res = factorialN / (factorialK * factorialNK);
        Console.WriteLine(res);
    }
}

