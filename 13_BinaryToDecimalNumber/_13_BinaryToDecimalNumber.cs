using System;

class _13_BinaryToDecimalNumber
{
    static void Main()
    {
        string binNumber = Console.ReadLine();

        long result = 0;
        int power = 1;
        for (int i = binNumber.Length - 1; i >= 0; i--)
        {
            int number = binNumber[i] - '0';
            result += number * power;
            power *= 2;
        }

        Console.WriteLine(result);
    }
}

