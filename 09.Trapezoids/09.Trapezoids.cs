/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _09.Trapezoids
{
    class Program
    {
        static void Main()
        {
            //The following line of code allows us to enter doubles such as 32.2 and 32,2 with equal outcomes (ie it works both ways)
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter the two sides and the height of the trapezoid: ");
            Console.Write("a = ");
            double side_a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double side_b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double height = double.Parse(Console.ReadLine());

            //Calculate the are
            double area = ((side_a + side_b) * height) / 2.0;

            Console.WriteLine("The area is {0}", area);
        }
    }
}
