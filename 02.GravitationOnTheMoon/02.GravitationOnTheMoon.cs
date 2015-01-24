/*Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */


using System;
using System.Threading;
using System.Globalization;

namespace _02.GravitationOnTheMoon
{
    class Program
    {
        static void Main()
        {
            //The following line of code allowes us to enter doubles such as 32.2 and 32,2 with equal outcomes (ie it works both ways)
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please, enter the person's weight: ");
            double weight = double.Parse(Console.ReadLine());
            //we can take care of "negative" weights
            if (weight < 0)
                weight = -weight;

            Console.WriteLine("Weight on the Moon: {0}", weight * 0.17);

        }
    }
}
