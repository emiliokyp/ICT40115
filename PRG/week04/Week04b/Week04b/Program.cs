using System;

namespace Week04b
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// In your own words/comment explain the difference between a while loop and a do while loop
				// A while loop runs while a condition is true, where as a do while loop will run atleast once and then check the condition, if the conidition is true the loop will run again.


			int balance = 100;
			do {
				Console.WriteLine ("1. Adjust balance");
				Console.WriteLine ("2. Check balance");
				Console.WriteLine ("3: Quit");
				string userInput = Console.ReadLine ();
			if (userInput == "1") {
				Console.WriteLine ("1. Add 10");
				Console.WriteLine ("2. Reduce 5");
				Console.WriteLine ("3. Back");
				userInput = Console.ReadLine();
				if (userInput == "1") {
					balance += 10;
				} else if (userInput == "2") {
					balance -= 5;
				} else if (userInput == "3") {
						continue;
				}
			} else if (userInput == "2") {
					Console.WriteLine ("Balance: {0}", balance);
			} else if (userInput == "3") {
				Console.WriteLine ("Exiting");
					break;
				}
			} while (true);
		}
	}
}
