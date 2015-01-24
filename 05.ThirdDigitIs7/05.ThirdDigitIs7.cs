/*Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.
 */

using System;

namespace _05.ThirdDigitIs7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer (with at least 3 digits): ");
            int integer = int.Parse(Console.ReadLine());
            int result = ((integer / 10) / 10 ) % 10;
            Console.WriteLine("The 3rd digit is 7? {0}", result == 7);
        }
    }
}
