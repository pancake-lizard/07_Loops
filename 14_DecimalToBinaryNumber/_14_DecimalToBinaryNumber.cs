using System;

class _14_DecimalToBinaryNumber
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        string binaryNumber = "";
        while (decimalNumber > 0)
        {
            int remainder = (int)decimalNumber % 2;
            decimalNumber /= 2;
            binaryNumber = remainder + binaryNumber;
        }

        Console.WriteLine(binaryNumber);
    }
}

