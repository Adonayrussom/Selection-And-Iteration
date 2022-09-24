using System;

namespace sess04_SelectionAndIteration
{
    /// <summary>
    /// C# program that displays the first ten integers using a while loop
    /// </summary>
    public class FirstTenIntsWhile
    {
        static void Main(string[] args)
        {
            int n = 1;

            while (n <= 10)
            {
                if (n < 10)
                    Console.Write($"{n}, ");
                else
                    Console.WriteLine($"and {n}.");
                n++;
            } 
        }
    }
}
