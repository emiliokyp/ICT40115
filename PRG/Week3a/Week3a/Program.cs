using System;

namespace Week3a
{
	class MainClass
	{
        public static void Main(string[] args)
        {
            const string USERNAME = "emiliokyp";
            const string PASSWORD = "password";

            Console.WriteLine("Please enter your username and password");
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            if (username == USERNAME && password == PASSWORD) {
                Console.WriteLine("Welcome, " + username);
            } else {
                Console.WriteLine("Incorrect login details");
            }

            Console.ReadLine(); //pause
            Console.Clear();

            Console.WriteLine("Enter a number between 0 and 10");
            string input = Console.ReadLine();
            int result = int.Parse(input);

            if (result == 2 || result == 7) {
                Console.WriteLine("you guessed a good number");
            } else {
                Console.WriteLine("Better luck next time");
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter your favourite colour");
            var colour = Console.ReadLine().ToLower();

            if (colour == "black" || colour == "white" || colour =="grey")
            {
                Console.WriteLine("Thats a shade not a colour...");
            } else
            {
                Console.WriteLine("neat");
            }

            Console.ReadLine(); //pause
            Console.Clear();

            Console.WriteLine("Please enter a valid email address");
            var email = Console.ReadLine();
            Console.WriteLine("Please confirm your email address");
            var emailConfirm = Console.ReadLine();

            if (email != emailConfirm)
            {
                Console.WriteLine("Emails did not match, please try again");
            } else
            {
                Console.WriteLine("Email address confirmed");
            }

            Console.ReadLine(); //pause
            Console.Clear();


		}
	}
}
