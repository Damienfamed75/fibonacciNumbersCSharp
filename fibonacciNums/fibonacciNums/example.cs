using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciNums
{
    public static class Program
    {
        public static string numString;
        public static int numFib, x;

        public static int fiboCalc(int num)
        {
            int a = 1, b = 0, temp;
            while (num >= -1)
            {
                temp = a;
                a = a + b;
                b = temp;
                num--;
            }
            return b;
        }

        public static void Main()
        {
            while(true) // repeats forever
            {
                Console.Clear();
                DetermineNumber(); // chooses random fibonacci number to ask
                Console.Write($"What's the {numString} number of the fibonacci sequence?\n\n> "); // Asks question
                string result = Console.ReadLine(); // Stores result into string
                if (Int32.TryParse(result, out x))  // Parses into integer 
                {
                    if (x == fiboCalc(numFib)) Console.Write("You're right!!"); // Checks if answer is correct
                    else Console.Write("You're wrong!!");                       // Or incorrect

                    Console.Write($" You answered: {result} : : Answer is: {fiboCalc(numFib).ToString()}");
                } else 
                {
                    Console.Write("What you inputted was not a number. Try again");
                }
                Console.Write("\n\n<Press Any Key to Restart>");
                Console.ReadKey();
            }
        }
        static void DetermineNumber ()
        {
            Random numGen = new Random();
            switch (numGen.Next(5, 11)) // New number picker between 5 and 11
            {
                case 5:
                    numString = "fifth";
                    numFib = 5;
                    break;
                case 6:
                    numString = "sixth";
                    numFib = 6;
                    break;
                case 7:
                    numString = "seventh";
                    numFib = 7;
                    break;
                case 8:
                    numString = "eighth";
                    numFib = 8;
                    break;
                case 9:
                    numString = "ninth";
                    numFib = 9;
                    break;
                case 10:
                    numString = "tenth";
                    numFib = 10;
                    break;
                default:    // if it messes up
                    numString = "eleventh";
                    numFib = 10;
                    break;
            }
        }
    }
}
