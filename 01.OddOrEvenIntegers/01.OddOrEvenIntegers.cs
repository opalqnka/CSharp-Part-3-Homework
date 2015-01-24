/*Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.
 */


using System;

namespace _01.OddOrEvenIntegers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter an integer: ");
            int integer = int.Parse(Console.ReadLine());

            Console.WriteLine("Odd?\n{0}", integer % 2 == 0 || integer == 0 ? false : true);

            //Or we can write it with if-else constructions
            /*
            if (integer % 2 == 0)
                Console.WriteLine("Odd?\nfalse");
            else if (integer == 0)
                Console.WriteLine("Odd?\nfalse");
            else
                Console.WriteLine("Odd?\ntrue");
             */
        }
    }
}
