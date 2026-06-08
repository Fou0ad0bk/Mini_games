using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playagain = true;
            string guess = "";
            string PCguess = "";
            Random rnd = new Random();

            while (playagain)
            {
                guess = "";
                PCguess = "";

                Console.WriteLine("Welcome to rock paper scissors!");
            
             Console.WriteLine("choose rock, paper or scissors :");
             while (guess != "rock" && guess != "paper" && guess != "scissors")
             {
                guess = (Console.ReadLine()?? "") .ToLower();
                if (guess != "rock" && guess != "paper" && guess != "scissors")
                {
                    Console.WriteLine("Invalid input, please choose rock, paper or scissors :");
                }
                guess = guess.ToLower();
             }
    


            

            int temp = rnd.Next(1, 4);

            if (temp == 1)
            {
                PCguess = "rock";
            }
            else if (temp == 2)
            {
                PCguess = "paper";
            }
            else
            {
                PCguess = "scissors";
            }
            Console.WriteLine($"Computer chose: {PCguess}");

            

            if (guess == PCguess)
            {
               Console.WriteLine("It's a tie!");
            }
            else if (
            (guess == "rock" && PCguess == "scissors") ||
            (guess == "paper" && PCguess == "rock") ||
            (guess == "scissors" && PCguess == "paper"))
            {
            Console.WriteLine("You win!");
            }
            else
            {
            Console.WriteLine("Computer wins!");
            }

                Console.WriteLine("Do you want to play? (y/n)");
                string answer =( Console.ReadLine()?? "").ToLower();

                if (answer == "y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
            
        }
    }
}