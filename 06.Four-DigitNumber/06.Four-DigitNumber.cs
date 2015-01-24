/*Problem 6
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
 */

using System;

namespace _06.Four_DigitNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter a 4-digit number (cannot start with 0): ");
            int number = int.Parse(Console.ReadLine());

            //Separate the 4 digits
            int one = number % 10;
            int ten = ( number / 10 ) % 10;
            int hundred = ((number / 10 ) / 10) % 10;
            int thousand = (((number / 10) / 10) / 10) % 10;

            int sum = one + ten + hundred + thousand;

            //Print out the sum of the 4 digits
            Console.WriteLine("The sum of the digits of the number {0} is {1}", number, sum);

            //Print out the number in reversed order
            Console.WriteLine("The number in reversed order is {0}{1}{2}{3}", one, ten, hundred, thousand);

            //Puts the last digit in the first position
            Console.WriteLine("The number when the last digit becomes first is {0}{1}{2}{3}", one, thousand, hundred, ten);

            //Exchanges the 2nd and 3rd digit of the original number
            Console.WriteLine("Exchanging the 2nd and 3rd digit of the original number gives us {0}{1}{2}{3}", thousand, ten, hundred, one);


        }
    }
}
