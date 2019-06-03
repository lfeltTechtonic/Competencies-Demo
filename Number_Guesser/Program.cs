using System;


//NameSpace
namespace Number_Guesser
{

    //MainClass
    class MainClass
    {

        //Entry Point Method (no public?)
        public static void Main(string[] args)
        {
            // Set app vars
            GetAppInfo(); //Run GetAppInfo Func to get info

            GreetUser(); // ask for name and greet 

            while (true)
            {
                //Set correct number 
                //int correctNumber = 7;

                //CREATE NEW random obj
                Random random = new Random();

                //init correct number 
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //get users input 
                    string input = Console.ReadLine();

                    //check for number

                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.DarkRed, "Please use acutal number");

                        //Keep going 
                        continue;
                    }


                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    { 
                        //Print error message
                    PrintColorMessage(ConsoleColor.DarkRed, "Wrong number, please try again");
                    }

                }

                // Output success message 

               //success message
                PrintColorMessage(ConsoleColor.DarkYellow, "You are correct! Good job! ");

                //Asl to play agian 
                Console.WriteLine("play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();
                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else 
                {
                return;
                 }

             }
        }

        //Get and display app info 

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "LKF";

            //Change Text color 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            // Write Out app info - header
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Resest Text color
            Console.ResetColor();
        }

        //ask users name and greet 
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your Name?");

            //Get User input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);

        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change Text color 
            Console.ForegroundColor = color;

            //Tell user NAN
            Console.WriteLine(message);

            //Resest Text color
            Console.ResetColor();
        }
    }
}
