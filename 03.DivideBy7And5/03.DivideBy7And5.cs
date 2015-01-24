/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
*/

using System;

namespace _03.DivideBy7And5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter an integer: ");
            int integer = int.Parse(Console.ReadLine());

            Console.WriteLine(integer % 5 == 0 && integer % 7 == 0 ? true : false);
        }
    }
}
