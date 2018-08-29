using System;

namespace week4a1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// create a basic menu
			string userInput = "";
			while(userInput != "quit") {
				//print the menu options
				Console.WriteLine("1. View List");
				Console.WriteLine("2. Add to List");
				Console.WriteLine("Quit: Exit program");

			// get input from user
				userInput = Console.ReadLine();
				if(userInput == "1")
				{
					Console.WriteLine("Viewing list");
				} else if (userInput == "2")
				{
					Console.WriteLine("Adding to list");
				} else if (userInput.ToLower() == "quit")
				{
					Console.WriteLine("Exiting");
				}
			}

			Console.WriteLine("Program complete");
			Console.ReadLine(); //pause
		}
	}
}
