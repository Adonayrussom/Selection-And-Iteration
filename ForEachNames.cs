using System;

namespace sess04_SelectionAndIteration
{
    /// <summary>
    /// C# program that uses the for...each loop to display the names of the students in the class.
    /// </summary>
    public class ForEachNames
    {
        static void Main(string[] args)
        {
            //Declare a string array of student names
            string[] studentNames = { "Russom", "Gitonga", "Kelly", "Elizabeth", "Veronica", "Saliem", "Miracle" };
            //Display the above names using a for ... each loop
            int n = 1;
            foreach (string name in studentNames)
            {
                Console.WriteLine($"Student{n:00}: {name}");
                n++;
            }
        }
    }
}
