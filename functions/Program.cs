using System;

namespace Methods
{
    class Program
    {
        // Create a method for return long number
        static long _Square(int number)
        {
            return number * number;
        }

        static void printResult_Square(int number) // ? Se puede pasar una funcion?
        {
            long result = _Square(number);
            Console.WriteLine(result);
        }

        // ! Min(int[]) return int
        static int Min(int[] args)
        {
            int result = Convert.ToInt32(1e9);
            foreach (int item in args)
            {
                result = (item < result ? item : result);
            }
            return result;
        }

        static int minAgeChildren(int children1, int children2, int children3)
        {
            return Min([children1, children2, children3]);
        }

        static void Main(string[] args)
        {
            printResult_Square(4);
            Console.WriteLine(minAgeChildren(children3: 3, children1: 4, children2: 1));
        }
    }
}