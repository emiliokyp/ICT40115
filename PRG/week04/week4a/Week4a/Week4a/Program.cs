using System;

namespace Week4a
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int counter = 0;
			//count from 0 to 10
			do {
				Console.WriteLine (counter);
				counter++;
			} while(counter <= 10);
				
			/* A do while loop will always run once as the condition is checked last. */
			Console.WriteLine ("-------------------------------------");
			// Create ado loop that counts from 0 to 100
			counter = 0;
			do {
				Console.WriteLine (counter);
				counter++;
			} while (counter < 100);
			// Create a do loop that counts from -10 to 10 by 2s
			Console.WriteLine ("-------------------------------------");
			counter = -10;
			do {
				Console.WriteLine(counter);
				counter += 2;
				} while(counter <= 10);
			// Create a while loop that countrs from 0 to 30 by 2s
			Console.WriteLine ("-------------------------------------");
			counter = 0;
			while (counter <= 30) {
				Console.WriteLine (counter);
				counter += 2;
			}
			// Create a do while loop that counts from 0 to 50 by 3s, increase by 5s once it reaches 25
			Console.WriteLine ("-------------------------------------");
			counter = 0;
			do {
				Console.WriteLine(counter);
				if (counter >=25) {
					counter += 5;
					continue;
				}
				counter += 3;
			} while(counter <= 50);
			Console.WriteLine ("-------------------------------------");

			// The break keyword is used to exit a loop prematurely
			// have the computer randomly generate a number, we are aiming for the number 5.
			// after 10 attempts quit if unsuccessful
			counter = 0;
			Random rand = new Random ();
			while (counter < 10) 
			{
				counter++;
				int guess = rand.Next (11);
				if (guess == 5)
					break;
			}
			Console.WriteLine ("it took {0} guesses", counter);
			Console.WriteLine ("-------------------------------------");
			counter = 0;
			while (counter < 10) 
			{
				Console.WriteLine (counter);
				int guess = rand.Next (11);
				if (guess == 5)
					continue;
				counter++;
			}
			Console.WriteLine ("it took {0} guesses", counter);
			Console.ReadLine (); //pause
		}
	}
}
	
