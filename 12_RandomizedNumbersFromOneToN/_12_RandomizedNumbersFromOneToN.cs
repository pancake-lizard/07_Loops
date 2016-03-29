using System;

class _12_RandomizedNumbersFromOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            myArray[i] = i + 1;
        }

        Random rnd = new Random();
        for (int j = 0; j < n; j++)
        {
            int randomIndex = rnd.Next(0, n);
            int temp = myArray[randomIndex];
            myArray[randomIndex] = myArray[j];
            myArray[j] = temp;
        }

        Console.WriteLine(String.Join(" ", myArray));
    }
}


