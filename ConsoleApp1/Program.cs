using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int userNumber = Convert.ToInt32( Console.ReadLine() );

            //switch (userNumber)
            //{
            //    case 1:
            //        //your code
            //        break;
            //    default:
            //        break;
            //}

            string userFirstName = string.Empty;
            string userLastName = string.Empty;
            int userAge = 0;

            char userSelection = Console.ReadKey(true).KeyChar;

            switch (userSelection)
            {
                case 'a':
                case 'A':
                    userFirstName   = AskUserFor("first name");
                    userLastName    = AskUserFor("last name");
                    userAge         = AskUserForNumber("age");
                    break;

                default:
                    break;
            }

            Console.WriteLine($"Hello {userFirstName} {userLastName}, so you are {userAge} years old");
        }//end of main

        static string AskUserFor(string what)
        {
            //Console.Write("Please enter " + what + ": ");
            //Console.Write("Please enter {0}: ", what);
            Console.Write($"Please enter {what}: ");

            return Console.ReadLine();
        }

        static int AskUserForNumber(string what)
        {
            return int.Parse(AskUserFor(what));
        }
    }//end of class program
}//end of namespace
