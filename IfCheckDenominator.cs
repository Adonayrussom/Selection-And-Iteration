using System;

namespace sess04_SelectionAndIteration
{
    /// <summary>
    /// C# program demonstrating the use of an if construct to prevent 
    /// interger division by zero.
    /// </summary>
    public class IfCheckDenominator
    {
        static void Main(string[] args)
        {
            //Variables to be used in the program
            uint numerator, denominator, quotient;
            //prompt the user for the numerator
            Console.WriteLine($"Please enter the numerator to be used in division -> ");
            numerator = uint.Parse(Console.ReadLine());

            UserPrompt: //Label that will be used in a goto statement
            //prompt the user for the numerator
            Console.WriteLine($"Please enter the denominator to be used in division -> ");
            denominator = Convert.ToUInt32(Console.ReadLine());

            //Check whether the user has entered a 0 as the denominator and prompt them for
            //a different number
            if(denominator == 0)
            {
                Console.WriteLine($"Please enter a non-zero \'0\' number/value as" +
                    $"division by zero will cause errors!!");
                goto UserPrompt;
            }

            quotient = numerator / denominator;
            //Displa the result
            Console.WriteLine($"{numerator} {'\u00f7'} {denominator} = {quotient}");
        }
    }
}
