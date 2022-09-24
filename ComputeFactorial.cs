using System;

namespace sess04_SelectionAndIteration
{
    /// <summary>
    /// C# program that calculates the factorial of a positive number entered by 
    /// the user using loops
    /// </summary>
    public class ComputeFactorial
    {
        public static void Main(string[] args)
        {
            //Variables to be used in the program
            int n = 1;
            long factorial = 1L;
            int usernum = -1;

            //use the while llop to ensure the user gives us a +ve number
            while (usernum <0)
            {
                Console.WriteLine("Please enter a positive whole number an I\'ll"
                    +" tell  you its factorial ->");
                usernum = int.Parse(Console.ReadLine());
            }

            //Use a switch with nested loops to compute the factorial
            switch (usernum)
            {
                case 0:
                case 1:
                    factorial = 1L;
                    break;
                case 2:
                    factorial = 2L;
                    break;
                default:
                    for (; n <= usernum; n++)
                        factorial *= n;
                    break;
            }
            //Display the factorial using a loop
            Console.WriteLine($"\nThe factorial of {usernum} is {factorial}");
        }
    }
}
