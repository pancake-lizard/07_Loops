using System;

class _11_RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("n : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min : ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max : ");
        int max = int.Parse(Console.ReadLine());

        if (min > max)
        {
            do
            {
                Console.WriteLine("Min should be less or equal to Max!");
                Console.Write("Min : ");
                min = int.Parse(Console.ReadLine());
                Console.Write("Max : ");
                max = int.Parse(Console.ReadLine());
            }
            while (min > max);
        }

        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}" + " ", rnd.Next(min, max + 1));
        }
        Console.WriteLine();
    }
}

