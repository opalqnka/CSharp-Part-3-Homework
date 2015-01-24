/*Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
K({0, 0}, 2) means -> center at 0, 0 and radius 2
 */

using System;
using System.Threading;
using System.Globalization;

namespace _07.PointInACircle
{
    class Program
    {
        static void Main()
        {
            //The following line of code allowes us to enter doubles such as 32.2 and 32,2 with equal outcomes (ie it works both ways)
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter a point on the X-Y plane: ");
            Console.Write("X = ");
            double x_coordinate = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            double y_coordinate = double.Parse(Console.ReadLine());

            double radiusOriginal = 2.0;
            double radiusEntered = Math.Sqrt((y_coordinate * y_coordinate) + (x_coordinate * x_coordinate));

            Console.WriteLine(radiusEntered <= radiusOriginal ? true : false);

        }
    }
}
