using System;

namespace sess04_SelectionAndIteration
{
    /// <summary>
    /// C# program that accepts a character from the user and determines if 
    /// it's a number or lowercase
    /// </summary>
    public class NumberOrLowercase
    {
        static void Main(string[] args)
        {
            //Prompt the user for a character
            Console.WriteLine("Please enter a character and I\'ll tell you if it"
                +" is a number or lowercase letter ->");
            char character = (char)Console.Read();

            if (character >= '0' && character <= '9')
            Console.WriteLine($"{character} is a number.\n");

            else if (character >= 'a' && character <='z')
            Console.WriteLine($"{character} is a lower case letter.\n");

            else
            Console.WriteLine($"{character} is neither a number nor a lower case letter.\n");
        }
    }
}
