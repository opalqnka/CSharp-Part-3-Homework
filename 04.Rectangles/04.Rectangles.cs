/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _04.Rectangles
{
    class Program
    {
        static void Main()
        {
            //The following line of code allowes us to enter doubles such as 32.2 and 32,2 with equal outcomes (ie it works both ways)
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter the width and height of the rectangle: ");
            Console.WriteLine("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Height: ");
            double height = double.Parse(Console.ReadLine());          

            double perimeter = 2 * (height + width);
            double area = height * width;

            Console.WriteLine("The perimeter is: {0}\nThe area is: {1}", perimeter, area);


        }
    }
}
