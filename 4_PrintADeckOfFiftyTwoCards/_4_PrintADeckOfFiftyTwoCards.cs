using System;

class _4_PrintADeckOfFiftyTwoCards
{
    static void Main()
    {
        char[] suitsCharArray = { '\u2663', '\u2666', '\u2665', '\u2660' };

        for (int i = 2; i <= 14; i++)
        {
            if (i <= 10)
            {
                for (int j = 0; j < suitsCharArray.Length; j++)
                {
                    Console.Write(i + "" + suitsCharArray[j] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                switch (i)
                {
                    case 11:
                        for (int j = 0; j <= 3; j++)
                        {
                            Console.Write("J" + suitsCharArray[j] + " ");
                        }
                        break;

                    case 12:
                        for (int q = 0; q <= 3; q++)
                        {
                            Console.Write("Q" + suitsCharArray[q] + " ");
                        }
                        break;

                    case 13:
                        for (int k = 0; k <= 3; k++)
                        {
                            Console.Write("K" + suitsCharArray[k] + " ");
                        }
                        break;

                    case 14:
                        for (int a = 0; a <= 3; a++)
                        {
                            Console.Write("A" + suitsCharArray[a] + " ");
                        }
                        break;

                    default: break;
                }
                Console.WriteLine();
            }
        }
    }
}
