using System;

namespace VotingEligibleCode
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What's your name?");
           string userName = Console.ReadLine();
           Console.WriteLine("Enter your age?");
           int age
           int.TryParse(Console.ReadLine(), out age);
           if (age2 >= 18)
            {
               Console.WriteLine("Great news " + userName + "! You can vote!");
            }
           else if (age2 <= 17)
            {
               Console.WriteLine("Sorry " + userName + ". You're too young to vote.");
            }
           else
            {
               Console.WriteLine("Invalid Entry");
            }

            
        }
    }
}
