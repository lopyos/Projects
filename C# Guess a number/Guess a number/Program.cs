using System;

namespace Guess_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            appinfo();//shows to all the app info to the user.

            greetUser();//ask for the users name and welcome him to the game.
            
            //Radom number
            Random rnd = new Random();

            //Var with the random number
            int correctNumber = rnd.Next(1, 10);

            //while vars
            int guess = 0;
            string playAgain = "0";

            //Input guess var
            while (guess != correctNumber)
            {
                //Get the input from the user
                string inputGuess = Console.ReadLine();

                //Make that the InputGuess is a number
                if(!Int32.TryParse(inputGuess, out guess))
                {
                    printColorMessage(ConsoleColor.Red, "Please put a number!!!");

                    continue;
                }
                //converting inputGuess to an int
                guess = Int32.Parse(inputGuess);

                //Condition if to check the input guess
                if (guess == correctNumber)
                {
                    printColorMessage(ConsoleColor.Yellow, "Congratolations you are right");
                    Console.WriteLine("Would you like to play this game again? y/n");
                    
                    while (playAgain != "y" && playAgain != "n")
                    {
                        playAgain = Console.ReadLine();

                        if (playAgain != "y" && playAgain != "n")
                        {
                            printColorMessage(ConsoleColor.Yellow,"Please insert Y or N");
                        }
                        else if (playAgain == "y")
                        {
                            //set guess to 0 to resent the variable
                            guess = 0;

                            //Repeated description
                            printColorMessage(ConsoleColor.Blue, "Lets the Game Begine\nGues a number from 1 to 10!!");

                            //create a new random number
                            correctNumber = rnd.Next(1, 10);                            
                        }
                    }
                    //reseting the function
                    playAgain = "0";                   
                }
                else
                {
                    //Error message
                    printColorMessage(ConsoleColor.Red, "Ups you need to try again if you fell like you can doit");
                }
            }
        }

        static void appinfo()//this is the app information
        {
            //App Vars
            string appName = "Guess Game";
            string appVersion = "v 1.0.0";
            string appAge = "25";
            string appAuthor = "Jose Rafael Tavare";

            //console color
            Console.ForegroundColor = ConsoleColor.Green;

            //information of the program
            Console.WriteLine("{0} V {1} My  name is {2} and im {3}", appName, appVersion, appAuthor, appAge);       
            
            //reset the color of the console.
            Console.ResetColor();
        }
        static void greetUser(){//Part of the app the greet the user
            //Get the name of the person
            Console.WriteLine("Whats Your name?");
            string inputName = Console.ReadLine();

            //Asking to Guess
            //console color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //information of the program
            Console.WriteLine("Hi {0}, welcome to the Guess Game!\nGuess a number between 1 and 10:", inputName);

            //reset the color of the console.
            Console.ResetColor();

        }
        static void printColorMessage(ConsoleColor color, string message)//Function to change the color of the messages whenever i want
        {
            //console color
            Console.ForegroundColor = color;

            //information of the program
            Console.WriteLine(message);

            //reset the color of the console.
            Console.ResetColor();
        }
    }
}
