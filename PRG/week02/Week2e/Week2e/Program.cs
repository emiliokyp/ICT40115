using System;

namespace Week2e
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int score = 49;
			// If statements are used to check if a result is true or false

			if (score < 50)
				Console.WriteLine ("Oh no you're failing!");


			if (score == 0)
				Console.WriteLine ("You are the worst");
			else
				Console.WriteLine ("You are not on 0 yay");

			string colour = Console.ReadLine ();
			if (colour == "blue")
				Console.WriteLine ("Blue is a terrible colour");
			else if (colour == "green")
				Console.WriteLine ("Green is a great colour");
			else if (colour == "red")
				Console.WriteLine ("Red is an okay colour");
			else
				Console.WriteLine ("There should be no other colours");


			string user = "test";
			string pass = "p@ssword";

			string userInput = Console.ReadLine ();
			string passInput = Console.ReadLine ();

			if (userInput == user && passInput == pass)
				Console.WriteLine ("Login Success");
			else
				Console.WriteLine ("Login Failed");


			int scoreInput = -1;
			while (scoreInput < 0 || scoreInput > 100) {
				Console.WriteLine ("Please enter a number between 0 and 100");
				scoreInput = int.Parse(Console.ReadLine());
			} 

			if (scoreInput < 50)
				Console.WriteLine ("Fail");
			else if (scoreInput < 59)
				Console.WriteLine ("Pass");
			else if (scoreInput < 69)
				Console.WriteLine ("Credit");
			else if (scoreInput < 79)
				Console.WriteLine ("Distinction");
			else 
				Console.WriteLine("High Distinction");
				

			Console.ReadLine (); //pause

		}
	}
}
