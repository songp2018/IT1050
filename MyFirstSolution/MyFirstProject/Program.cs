using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //print the value of the user's full name to the screen
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            string answer;
            int heightFeet;
            double heightInches;
            double totalHeightCM;
            int age;
            bool isCitizen;
            bool canVote;
            Console.Write("What is your first name?");
            firstName = Console.ReadLine();

            Console.Write("What is your middle initial?");
            middleInitial = Console.ReadLine();

            Console.Write("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine(firstName + " " + middleInitial + " " + lastName);

            // Ask the user what their height in feet and print the value of totalHeightCM to the screen
            Console.Write("What  is your height in feet?");
            heightFeet = int.Parse(System.Console.ReadLine());

            Console.Write("How many inches beyond your height in feet to add to your height?");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = (heightInches + (heightFeet * 12)) * 2.54;
            Console.WriteLine("Your height in cm is " + totalHeightCM + "cm" + ". ");

            // print the vallue of canVote to the screen
            Console.Write("Age?");
            age = int.Parse(System.Console.ReadLine());
            Console.Write("Citizen? (y/n):");
            isCitizen = Console.ReadLine().ToLower().StartsWith("Y");
        }
    }
}


           