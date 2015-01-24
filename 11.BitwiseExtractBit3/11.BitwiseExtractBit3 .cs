/*Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
 */

using System;


namespace _11.BitwiseExtractBit3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer");
            int integer = int.Parse(Console.ReadLine());
            int position = 3;

            int mask = 1 << position;
            int integerAndMask = mask & integer;
            Console.WriteLine(integerAndMask >> position);

        }
    }
}
