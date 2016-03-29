using System;
using System.Numerics;

class _6_CalculateNFactorialDevidedByKFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger result = 1;
        while (n > k)
        {
            result *= n;
            n--;
        }
        Console.WriteLine(result);
    }
}