using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayAppInfo();

            GreetUser();

            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                int guess = 0;

                PrintColorMessage(ConsoleColor.Yellow, "Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Use an actual number idiot...");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong!");
                    }
                }

                PrintColorMessage(ConsoleColor.Green, "You're a genius!");

                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    PrintColorMessage(ConsoleColor.Red, "Deuces");

                    return;
                }
                else
                {

                    PrintColorMessage(ConsoleColor.Red, "It's Y or N dummy. Program terminated!");

                    return;
                }
            }

        }

        static void DisplayAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Bill Buff";

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Welcome {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
