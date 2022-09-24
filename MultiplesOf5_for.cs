using System;
namespace sess04_SelectionAndIteration
{
    /// <summary>
    /// C# program to display the first ten mulitiples of 5 using the for loop.
    /// </summary>
    public class MultiplesOf5_for
    {
        public static void Main(string[] args)
        {
            for (int n =1; n <= 10; n++)
            {
                Console.WriteLine($"{n,2} x 5 = {n * 5,2}");
            }
        }
    }
}
