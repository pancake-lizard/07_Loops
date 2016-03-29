using System;

class _10_OddAndEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < inputArray.Length; i++)
        {
            int number = int.Parse(inputArray[i]);
            if (i % 2 == 0 || i == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}

