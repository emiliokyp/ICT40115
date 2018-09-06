using System;

namespace week05b
{
	class MainClass
	{
		enum Days {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
		enum Colour {Red, Green, Blue, Yellow};
		enum Menu {New, Open, Save, Exit};

		public static void Main (string[] args)
		{
			/*
			 * Enumerators are used to group related constants that are readable by
			 * programmers but are simple numbers behind the scenes
			 * These are often used for codes such as days of the week or common colors
			 * 
			 * You declare the new enumerator type with the enum keyword and then a name.
			 * From there you enter the names of its types
			 * 
			 */

			Days currentDay = Days.Wednesday;
			Days tomorrow = Days.Thursday;

			Colour favouriteColour = Colour.Blue;

			Console.WriteLine ("Enter your favourite color");
			string input = Console.ReadLine ().ToLower ();

			switch (input) {
			case "blue":
				favouriteColour = Colour.Blue;
				break;
			case "red":
				favouriteColour = Colour.Red;
				break;
			case "green":
				favouriteColour = Colour.Green;
				break;
			case "yellow":
				favouriteColour = Colour.Yellow;
				break;
			default:
				Console.WriteLine ("Invalid input");
				break;
			}


			if (favouriteColour == Colour.Green) {
				Console.WriteLine ("Correct answer");
			} else {
				Console.WriteLine ("Bad Choice");
			}


			Console.WriteLine ("1: New\n2: Open\n3: Save\n4: Exit");
			int userInput = int.Parse (Console.ReadLine ());
			Menu selection = Menu.Save;
			switch (userInput) {
			case 1:
				selection = Menu.New;
				break;
			case 2:
				selection = Menu.Open;
				break;
			case 3:
				selection = Menu.Save;
				break;
			case 4:
				selection = Menu.Exit;
				break;
			default:
				Console.WriteLine ("Invalid input");
				break;
			}

			Console.WriteLine ("User selected {0}", selection);
			if (selection == Menu.New)
				Console.WriteLine ("The file has been created");
			else if (selection == Menu.Open)
				Console.WriteLine ("Navigate to the file you would like to open");
			else if (selection == Menu.Save)
				Console.WriteLine ("The file has been saved");
			else if (selection == Menu.Exit)
				Console.WriteLine ("Program has been closed");


		}
	}
}
