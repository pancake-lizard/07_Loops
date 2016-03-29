using System;

class _3_MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] arrayOfNumbers = new double[n];

        double sum = 0;
        double average = 0;

        for (int i = 0; i < n; i++)
        {
            arrayOfNumbers[i] = double.Parse(Console.ReadLine());
        }
 
        Array.Sort(arrayOfNumbers);
        Console.WriteLine("min = {0}", arrayOfNumbers[0]);
        Console.WriteLine("max = {0}", arrayOfNumbers[n - 1]);

        for (int i = 0; i < n; i++)
        {
            sum += arrayOfNumbers[i];
        }
        Console.WriteLine("sum = {0}", sum);
        average = sum / n;
        Console.WriteLine("avg = {0:F2}", average);
    }
}

