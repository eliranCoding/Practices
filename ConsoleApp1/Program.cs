using System;

namespace ConsoleApp1
{
    class Practice
    {
        static void Main(string[] args)
        {
            //  display n terms of natural number and their sum:
            Random RAND = new Random();
            int COUNTER = 0;
            for (int i = 0; i < RAND.Next(1, 100); i++)
            {
                Console.WriteLine("CURRENT NUMBER: " + i);
                COUNTER += i;
                Console.WriteLine("SUM:" + COUNTER);
                Console.ReadKey();
            }
        }
    }
}
