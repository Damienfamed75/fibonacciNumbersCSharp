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
            while(true)
            {
                Console.Clear();
                DetermineNumber();
                Console.Write($"What's the {numString} number of the fibonacci sequence?\n\n> ");
                string result = Console.ReadLine();
                if (Int32.TryParse(result, out x))
                {
                    if (x == fiboCalc(numFib))
                    {
                        Console.Write($"You're right!! You answered: {result} : : Answer is: {fiboCalc(numFib).ToString()}\n\n<Press Any Key to Restart>");
                    }
                    else
                    {
                        Console.Write($"You're wrong!! You answered: {result} : : Answer is: {fiboCalc(numFib).ToString()}\n\n<Press Any Key to Restart>");
                    }
                }
                Console.ReadKey();
            }
        }
        static void DetermineNumber ()
        {
            Random numGen = new Random();
            switch (numGen.Next(5, 11))
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
                default:
                    numString = "eleventh";
                    numFib = 10;
                    break;
            }
        }
    }
}
