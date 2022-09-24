using System;

namespace sess04_SelectionAndIteration
{
    /// <summary>
    /// C# program that displays the first ten integers using a do....while loop
    /// </summary>
     public class FirstTenIntsDoWhile
    {
        static void Main(string[] args)
        {
            int n = 1;
            do
            {
                if(n < 10)
                    Console.Write($"{n}, ");
                else
                    Console.WriteLine($"and {n}.");
                n++;
            } while (n <= 10);
        }
    }
}
