using System;

namespace week05c
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 * A for loop is commonly used for counting to a certain point
			 * e.g. counting from 0 to 100 or counting through a list of data
			 * it has a unique structure
			 * for (int i =0; i < number; ++i)
			 * 
			 * The format starts with a counter variable (int i = 0;)
			 * then we have the condition (i < number)
			 * From here it goes into the loop ( if the condition is true) and runs the code
			 * It then jumps out and runs a counter modifier (++i)
			 * it will then check the condition again and loop if it is still true
			 * 
			 */

			for (int i = 0; i < 10; ++i) {
				Console.WriteLine (i);
			}


			/*
			 * Loop from 0 to 100 inclusive
			 * -10 to 10 inclusive
			 * 100 to 1000 by 100s
			 */

			for (int i = 0; i <= 100; ++i) {
				Console.WriteLine (i);
			}

			Console.WriteLine ("--------------------------------");

			for (int i = -10; i <= 10; ++i) {
				Console.WriteLine (i);
			}

			Console.WriteLine ("--------------------------------");

			for (int i = 100; i <= 1000; i += 100) {
				Console.WriteLine (i);
			}

			Console.WriteLine ("--------------------------------");

			for (int i = 0; i <= 100; i += 2) {
				Console.WriteLine (i);
				if (i >= 30) {
					i += 8;
				}
			}

			Console.WriteLine ("--------------------------------");

			for (int i = 100; i >= 0; --i) {
				Console.WriteLine (i);
			}

			Console.WriteLine ("--------------------------------");

			for (int i = 0; i <= 1000; i += 10) {
				Console.WriteLine (i);
				if (i >= 100) {
					i += 190;
				}

			}


		}
	}
}
