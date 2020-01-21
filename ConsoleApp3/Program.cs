using System;

namespace ConsoleApp3
{
    class Practice3
    {
        // Console.WriteLine();
        // Console.ReadLine();
        // Console.ReadKey();
        static void Main (string[] args)
        {
            // Equation: A*X^2 + B*X + C
            double numA, numB, numC;

            Console.WriteLine("Enter the 'A': ");
            numA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 'B': ");
            numB = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 'C': ");
            numC = double.Parse(Console.ReadLine());

            Console.WriteLine("Your Equation: " + Type_A(numA) + "x^2" + Type_B(numB) + "x" + Type_C(numC));
            Console.ReadKey();

            On_Calculation(numA, numB, numC);
        }

        public static string Type_A(double numA)
        {
            if (numA == 1) return "";
            
            else if (numA == -1) return " -";
            
            else return numA.ToString();
        }

        public static string Type_B (double numB)
        {
            if (numB > 0)
            {
                if (numB == 1) return " + ";

                return " + " + numB;
            }
            else 
            { 
                if (numB == -1) return " - ";
                
                return " - " + -numB;
            }
        }

        public static string Type_C (double numC)
        {
            if (numC > 0) return " + " + numC;
            
            else return " - " + -numC;
        }

        public static void On_Calculation (double numA, double numB, double numC)
        {
            // Calculation: Positive (x1): -B + (sqrt((-B)^2 - 4 * A * C)) / 2 * A 
            // Calculation: Negative (x2): -B + (sqrt((-B)^2 - 4 * A * C)) / 2 * A

            double x1 = (-numB + Math.Sqrt(numB * numB - 4 * numA * numC)) / (2 * numA);
            double x2 = (-numB - Math.Sqrt(numB * numB - 4 * numA * numC)) / (2 * numA);

            Console.WriteLine("x1 = " + x1 + " , x2 = " + x2);
            Console.ReadKey();
        }
    }
}
