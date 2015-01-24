/*Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2)
CLARIFICATION: After checking in the forum the coordinates of the rectangle are the following:
Upper left corner :(х= -1; у= 1)
Upper right corner :(х= 5; у= 1)
Lower left corner  :(х= -1; у= - 1)
Lower right corner :(х= -5; у= -1)
 */

using System;
using System.Threading;
using System.Globalization;


namespace _10.PointInsideACircleAndOutsideARectangle
{
    class Program
    {
        static void Main()
        {
            //The following line of code allowes us to enter doubles such as 32.2 and 32,2 with equal outcomes (ie it works both ways)
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter a point on the X-Y plane: ");
            Console.WriteLine("X = ");
            double x_coordinate = double.Parse(Console.ReadLine());
            Console.WriteLine("Y = ");
            double y_coordinate = double.Parse(Console.ReadLine());


            //define the circle by giving centre coordinates and the radius
            double centre_circle_x = 1.0;
            double centre_circle_y = 1.0;
            double radiusOriginal = 1.5;

            //calculate the distance between the centre of the circle and the entered point (x, y)
            double radiusEntered = Math.Sqrt(((y_coordinate - centre_circle_y) * (y_coordinate - centre_circle_y)) +
                ((x_coordinate - centre_circle_x)  * (x_coordinate - centre_circle_x)));
            
            //check if the point (x, y) satisfies the requirements in the problem
            bool decide = (radiusEntered <= radiusOriginal && y_coordinate > 1.0);

            Console.WriteLine(decide ? "yes" : "no");
        }
    }
}
