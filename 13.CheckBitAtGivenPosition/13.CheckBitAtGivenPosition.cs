/*Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
 */

using System;


namespace _13.CheckBitAtGivenPosition
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter an integer n: ");
            int integer = int.Parse(Console.ReadLine());
            Console.Write("Please, indicate the index of the bit: ");
            int position = int.Parse(Console.ReadLine());

            int mask = 1 << position;
            int integerAndMask = mask & integer;
            Console.WriteLine((integerAndMask >> position) == 1);
        }
    }
}
