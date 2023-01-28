using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to roll the dice y/n");
        string choice = Console.ReadLine();

        while (true)
        {
            if (choice == "y")
            {
                int y = new Random().Next(1, 7);

                Console.WriteLine("Number rolled - " + y + " Do you want to play again y/n");

                string choice2 = Console.ReadLine();

                    if (choice2 == "y")
                    {

                    }

                    if (choice2 == "n")
                    {
                    Environment.Exit(0);
                    }
            }

            if (choice == "n")
            {
                Environment.Exit(0);

;
            }
            
        }
    }
}