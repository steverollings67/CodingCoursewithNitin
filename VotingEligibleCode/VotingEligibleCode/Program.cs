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
            string age = Console.ReadLine();
            int age2 = Int32.Parse(age);
            if (age2 >= 18)
            {
                Console.WriteLine("Great News! You can vote!");
            }
            else if (age2 <= 17)
            {
                Console.WriteLine("Sorry. You're too young to vote");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }
}
