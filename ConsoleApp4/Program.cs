using System;

namespace ConsoleApp4
{
    class Coin
    {
        static void Main(string[] args)
        {
            int groupA, groupB;

            int[] coin = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] mass = new int[8];

            for (int i = 0; i < coin.Length; i++)
            {
                if (coin[i] == 9)
                {
                    break;
                }

                Console.WriteLine("Enter the ring number " + coin[i] + " mass:");
                mass[i] = int.Parse(Console.ReadLine());
            }

            groupA = mass[0] + mass[1] + mass[2];
            groupB = mass[3] + mass[4] + mass[5];

            ///////////CHECKING FAKE COIN////////////

            if (groupA == groupB)
            {
                if (mass[6] == mass[7])
                {
                    Console.WriteLine("coin number 9 is the fake coin!");
                    Console.ReadKey();
                }

                else if (mass[6] < mass[7])
                {
                    Console.WriteLine("coin number 7 is the fake coin!");
                    Console.ReadKey();
                }

                else 
                {
                    Console.WriteLine("coin number 8 is the fake coin!");
                    Console.ReadKey();
                }
            }

            else if (groupA < groupB)
            {
                if (mass[0] == mass[1])
                {
                    Console.WriteLine("coin number 3 is the fake coin!");
                    Console.ReadKey();
                }

                else if (mass[0] < mass[1])
                {
                    Console.WriteLine("coin number 1 is the fake coin!");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("coin number 2 is the fake coin!");
                    Console.ReadKey();
                }
            }

            else
            {
                if (mass[3] == mass[4])
                {
                    Console.WriteLine("coin number 6 is the fake coin!");
                    Console.ReadKey();
                }

                else if (mass[3] < mass[4])
                {
                    Console.WriteLine("coin number 4 is the fake coin!");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("coin number 5 is the fake coin!");
                    Console.ReadKey();
                }
            }
        }
    }
}
