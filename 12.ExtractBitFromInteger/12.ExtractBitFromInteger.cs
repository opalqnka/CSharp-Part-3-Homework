/*Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.
 */

using System;

namespace _12.ExtractBitFromInteger
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
            Console.WriteLine(integerAndMask >> position);

        }
    }
}
