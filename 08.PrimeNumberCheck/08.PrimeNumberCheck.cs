/*Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
 */
using System;

namespace _08.PrimeNumberCheck
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a positive integer n (n <= 100): ");
            int number = int.Parse(Console.ReadLine());

            //Check if the number is not positive
            if (number <= 0)
            {
                Console.WriteLine(false);
                Console.WriteLine("You have entered an invalid number. Please, try again");
                return;
            }

            //Define a bool which keeps track if the number is not prime
            bool isPrime = true;

            //use a for-loop to go from 2 to the number while checking if i divides the number
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    isPrime = false;
            }

            //check the value of isPrime and give final answer
            if (isPrime == true)
            {
                Console.WriteLine(isPrime);
                Console.WriteLine("The number {0} is prime.", number);
            }
            else
            {
                Console.WriteLine(isPrime);
                Console.WriteLine("The number {0} is not prime.", number);
            }

        }
    }
}
