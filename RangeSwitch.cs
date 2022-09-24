using System;
namespace sess04_SelectionAndIteration
{
    /// <summary>
    /// C# program demonstrating a ranged switch construct
    /// </summary>
    public class RangeSwitch
    {
        static void Main(string[] args)
        {
            sbyte studScore;

            //Prompt the user for the student's score in the exam
            Console.WriteLine("Please enter the student\'s score in the exam: (0-100) ->");
            studScore = sbyte.Parse(Console.ReadLine());

            //The code below requires C# 7.0 upwards to run
            //switch (studScore)
            //{
            //    case sbyte n when studScore >= 0 && studScore < 40:
            //        Console.WriteLine("Unfortunately you failed in the exam");
            //        break;
            //    case sbyte n when studScore >= 0 && studScore < 40:
            //        Console.WriteLine("Congratulation you passed the exam");
            //        break;
            //    default:
            //        Console.WriteLine("Sorry, you entered an invalid score."
            //            + "\nPlease enter a score within the range of 0 -100");
            //        break;
            // }
        }
    }
}
