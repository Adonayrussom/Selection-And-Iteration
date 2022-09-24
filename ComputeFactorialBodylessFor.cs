using System;
namespace sess04_SelectionAndIteration
{
    public class ComputeFactorialBodylessFor
    {
        public static void Main(string[] args)
        {
            int n = 1;
            long factorial = 1L;
            int usernum = -1;



            //Use loop to make sure the user gives us a +ve number
            while (usernum < 0)
            {
                Console.WriteLine("Please enter a positive whole number and i\'ll tell you it\'s factorial");
                usernum = Convert.ToInt32(Console.ReadLine());
            }
            //Compute the factorial using a bodyless for loop
            for (; n <= usernum; factorial *= n++) ;



            //Display the factorial using a bodyless loop
            Console.WriteLine($"\nThe factorial of {usernum} is {factorial}");
        }
    }
}
