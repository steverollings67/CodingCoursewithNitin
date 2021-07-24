using System;

namespace VotingEligibleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
        DataEntry:
            Console.WriteLine("Enter your age?");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            if (age >= 18)
            {
                Console.WriteLine("Great news " + userName + "! You can vote!");
            }
            else if (age <= 17)
            {
                Console.WriteLine("Sorry " + userName + ". You're too young to vote.");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
            goto DataEntry;
        }
    }
}
