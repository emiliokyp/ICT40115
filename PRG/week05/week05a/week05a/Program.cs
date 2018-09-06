using System;

namespace week05a
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*A switch statement can be used like a nested if/else statement
			 * The idea is you have cases to match text, characters or numbers
			 * when a case is found that matches the input (selection in this case)
			 * then it will jump to that code.
			 * it will continue in that section until it finds a break or return statement.
			 */
		
			Console.WriteLine ("Please enter a number from 0 to 3");
			int selection = int.Parse(Console.ReadLine());
			switch (selection) {
			case 0:
				Console.WriteLine ("Bad selection");
				break;
			case 1:
				Console.WriteLine ("You selected to add");
				break;
			case 2:
				Console.WriteLine ("You selected to remove");
				break;
			case 3:
				Console.WriteLine ("You selected to repeat");
				break;
			}

			Console.WriteLine ("Please enter a number from 0 to 3");
			selection = int.Parse(Console.ReadLine());

			switch (selection) {
			case 10:
				Console.WriteLine ("Some Text");
				break;
			case 11:
			case 12:
			case 13:
				Console.WriteLine ("You've entered 11, 12 or 13");
				break;
			case 14:
			case 15:
				Console.WriteLine ("You've entered 14 or 15");
				break;
			default:
				Console.WriteLine ("Invalid selection");
				break;
			}
				
			do {
				Console.WriteLine ("For internet banking press 1");
				Console.WriteLine ("For accounts press 2");
				Console.WriteLine ("For fraud support press 3");
				Console.WriteLine ("To hear the options again press 0");
				selection = int.Parse (Console.ReadLine ());
				switch (selection) {
				case 0:
					continue;
				case 1:
					Console.WriteLine ("You are now speaking to internet banking");
					break;
				case 2:
					Console.WriteLine ("You are now speaking to accounts department");
					break;
				case 3:
					Console.WriteLine ("You are now speaking to fraud support");
					break;
				default:
					Console.WriteLine ("Invalid input");
					continue;
				}
			} while (selection == 0);

			

		}
	}
}
