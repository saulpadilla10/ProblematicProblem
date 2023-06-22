using System;
using System.Collections.Generic;
using System.Threading;

public class ProblematicProblem
{

    static Random rng = new Random();
    //static bool cont = true;
    static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

    static void Main(string[] args)
    {
        Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
        bool cont = (Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase));
        if (!cont)
        {
            Console.WriteLine("Fine. Bye.");
            return;
        }
        Console.WriteLine();

        Console.Write("We are going to need your information first! What is your name? ");
        string userName = Console.ReadLine();
        Console.WriteLine();

        int userAge;

        while (true)
        {
            Console.Write("What is your age? ");
            bool ageValid = int.TryParse(Console.ReadLine(), out userAge);

            if (ageValid)
            {
                break;
            }

            Console.WriteLine("Please enter a valid numeric value.");
        }
        Console.WriteLine();

        Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
        bool seeList = (Console.ReadLine().Equals("sure", StringComparison.OrdinalIgnoreCase));
        if (!seeList)
        {
            Console.WriteLine("Really? Ok then.");
        }

        if (seeList)
        {
            foreach (string activity in activities)
            {
                Console.Write($"{activity} ");
                Thread.Sleep(250);
            }
            Console.WriteLine();

            Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            bool addToList = (Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            if (!addToList)
            {
                Console.WriteLine("Good. Great. Grand!");
              
            }

            while (addToList)
            {
                Console.Write("What would you like to add?");
                string userAddition = Console.ReadLine();
                activities.Add(userAddition);

                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();

                Console.WriteLine("Would you like to add more? yes/no: ");
                addToList = Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase);
            }
        }

    while (cont)
    {
        Console.Write("Connecting to the database");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
        Console.WriteLine();

        Console.Write("Choosing your random activity");

        for (int i = 0; i < 9; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
        Console.WriteLine();

        int randomNumber = rng.Next(activities.Count);
        string randomActivity = activities[randomNumber];

        if (userAge < 21 && randomActivity == "Wine Tasting")
        {
            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            Console.WriteLine("Pick something else!");
            activities.Remove(randomActivity);
            randomNumber = rng.Next(activities.Count);
            randomActivity = activities[randomNumber];
        }

            Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
            Console.WriteLine();

            if (cont = Console.ReadLine().Equals("keep", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Great! Enjoy {randomActivity}");
                return;

            }
        }
        while (!cont)
        {
            Console.WriteLine("Ok, just hit enter to generate new activity:");
            string redoInput = Console.ReadLine();
            if (!redoInput.Equals("redo", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();

                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");
                    activities.Remove(randomActivity);
                    randomNumber = rng.Next(activities.Count);
                    randomActivity = activities[randomNumber];
                }

                Console.Write($"New random activity is: {randomActivity}! Keep or redo? Keep/Redo: ");
                Console.WriteLine();
                cont = Console.ReadLine().Equals("keep", StringComparison.OrdinalIgnoreCase); ;

                Console.WriteLine($"Cool! Enjoy {randomActivity}!");

            }

        }


    }
}