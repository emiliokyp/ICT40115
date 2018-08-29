using System;

namespace Week2d
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// You can't create a constant, which is essentially a variable that can't change
			const int DAYS_IN_YEAR = 365;
			const int MAX_NAME_LENGTH = 40;

			// They can be used to designate a value that you don't want to change.
			// One common convention is to use all capitals and _ but this isn't mandatory.
			const float maxDistance = 9999.99f;

			// MaxDistance = 80; // This throws an error as you are trying to change a constant
			Console.WriteLine("There are " + DAYS_IN_YEAR + " days in a year");
			// Constants can be used just like normal variable other than changing its value

			// Ask user for an amount of years
			Console.WriteLine("Please enter a number of years");
			int numYears = int.Parse (Console.ReadLine ());
			int totalDays = numYears * DAYS_IN_YEAR;
			Console.WriteLine ("There are {0} days in {1} years", totalDays, numYears);

			Console.ReadLine ();
		}
	}
}
