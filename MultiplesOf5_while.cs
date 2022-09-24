using System;

namespace sess04_SelectionAndIteration
{    
     /// <summary>
     /// C# program to display the first ten mulitiples of 5 using the while loop.
     /// </summary>
    public class MultiplesOf5_while
    {
        public static void Main(string[] args)
        {
            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine($"{n,2} x 5 = {n * 5,2}");
                n++;
            }
        }
    }
}
