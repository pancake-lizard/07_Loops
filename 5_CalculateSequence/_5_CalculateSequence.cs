using System;

class _5_CalculateSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        double nFactorial = 1;
        double xPoweredByN = x;
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            double result = nFactorial / xPoweredByN;
            sum += result;
            xPoweredByN *= x;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}

