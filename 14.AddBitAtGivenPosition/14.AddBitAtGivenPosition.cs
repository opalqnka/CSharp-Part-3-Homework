/*Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n 
while preserving all other bits in n.
 */
using System;


namespace _14.AddBitAtGivenPosition
{
    class Program
    {
        static void Main()
        {
            //Get the integer, the index and the required new bit value
            Console.Write("Please, enter an integer n: ");
            int integer = int.Parse(Console.ReadLine());
            Console.Write("Please, indicate the index of the bit: ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Please, give value of the chosen bit: ");
            int value = int.Parse(Console.ReadLine());

            int mask = 1 << position;

            //Check for incorrect bit value
            if (!((value == 0) ^ (value == 1)))
            {
                Console.WriteLine("Incorrect choise for v, please try again!");
                return;
            }

            //use if-else constructions
            if (value == 0)
            {
                int reverseMask = ~mask;
                int reverseMaskAndInteger = integer & reverseMask;
                Console.WriteLine("The result is: {0}", reverseMaskAndInteger);
            }
            else
            {
                int maskOrInteger = integer | mask;
                Console.WriteLine("The result is: {0}", maskOrInteger);
            }

        }
    }
}
