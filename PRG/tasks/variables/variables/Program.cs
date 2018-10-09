using System;

namespace variables
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 * 
			 * Write a C# Console application that has the following functionality:
1.	Ask for and read the user's first name;
2.	Ask for and read the user's surname;
3.	Ask for and read the user's studentID;
4.	Ask for and read the user's year of birth;
5.	Ask for and read the current year;
6.	Display the user's first name and surname and age;

			 * 
			 */
			Console.WriteLine ("Enter your first name:");
			string firstName = Console.ReadLine ();
			Console.WriteLine ("Enter your last name:");
			string lastName = Console.ReadLine ();
			Console.WriteLine ("Enter your Student ID");
			string studentID = Console.ReadLine ();
            Console.WriteLine("Please enter your year of birth");
            string birthYear = Console.ReadLine();
            Console.WriteLine("What is the current year?");
            string currentYear = Console.ReadLine();

            Console.WriteLine("{0} {1}, {2}", firstName, lastName, (int.Parse(currentYear) - int.Parse(birthYear)));
		}
	}
}
