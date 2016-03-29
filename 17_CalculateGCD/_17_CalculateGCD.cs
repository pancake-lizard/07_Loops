using System;

class _17_CalculateGCD
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double result;
        double resultRemainder;

        while (true)
        {
            result = a / b;
            resultRemainder = a % b;
            if (resultRemainder != 0)
            {
                a = b;
                b = resultRemainder;
            }
            else
            {
                Console.WriteLine("{0}", b);
                break;
            }
        }
    }
}

