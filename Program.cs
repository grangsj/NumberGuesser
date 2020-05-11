using System;

namespace NumberGuesser
{
    //Main class
    class Program
    {
        //Main program entry point        
        static void Main(string[] args)
        {
            
            //Show the app info
            GetAppInfo();

            //Greet the user
            GreetUser();

            //Set number variables
            int correctNumber = 0;
            int guess = 0;

            while (true)
            {
                //Assign random number
                Random random = new Random();
                correctNumber = random.Next(1, 10);
              
                while (guess != correctNumber)
                {
                    //Ask for guess
                    Console.Write("Guess a number between 1 and 10? ");
                    string inputNumber = Console.ReadLine();

                    //Make sure inputNumber is a number
                    if (!int.TryParse(inputNumber, out guess))
                    {

                        //Display error message to user
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number!");                      

                        //Keep going
                        continue;
                    }

                    //Convert guess to integer.
                    guess = Int32.Parse(inputNumber);

                    //Evaluate guess
                    if (guess != correctNumber)
                    {
                        //Display error message to user
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");                     
                    }
                }

                //Notify user that they got the right answer
                PrintColorMessage(ConsoleColor.Green, "Yay, you got the right answer!!");

                //Ask user if they want to play again
                Console.Write("Do you want to play again [Y or N]");
                string playAgainAnswer = Console.ReadLine().ToUpper();

                if (playAgainAnswer != "N")
                {
                    continue;
                } else
                {
                    return;
                }
            }





        }

        //Convenience method to display basic app info
        static void GetAppInfo()
        {
            //Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Steve Granger";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write header text
            Console.WriteLine("{0}:  Version {1} by {2}", appName, appVersion, appAuthor);

            //Change text color back to normal
            Console.ForegroundColor = ConsoleColor.White;

        }

        //Convenience method to ask user's name and welcome them to the game
        static void GreetUser()
        {
            //Ask user's name
            Console.Write("What is your name?  ");

            //Get user input & respond to user
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}!  Let's play a game!", inputName);
        }

        //Convenience method to print out a colored message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Write header text
            Console.WriteLine(message);

            //Change text color back to normal
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
