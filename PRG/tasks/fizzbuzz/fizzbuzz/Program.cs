using System;

namespace fizzbuzz
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int counter = 0;
			while (counter <= 100) {

				if (counter % 3 == 0 && counter % 5 == 0) {
					Console.WriteLine ("FizzBuzz");
					counter++;
					continue;
				}
				else if (counter % 3 == 0)
					Console.WriteLine ("Fizz");
				else if (counter % 5 == 0)
					Console.WriteLine ("Buzz");
				else
					Console.WriteLine (counter);

				counter++;
			}
		}
	}
}
