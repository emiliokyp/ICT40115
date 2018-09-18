using System;

namespace week06a
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// write the function name to call it
			Message(); //this will run all of the code written in Message
			Message();
			Message ();
			DifferentMessage ("lskmflksmfslmksklfmsklfm");
			ThirdFunction (3, 4, 5);
			add (3, 5);
			highest (4, 2);
			floatMultiply (3.4f, 5.4f, 6.54f, 7.43f);
		}

		/*
		 * A function is used to run the same code in multiple places
		 * it allows you to easily write and update code in one location
		 * instead of several
		 * 
		 */

		public static void Message()
		{
			Console.WriteLine ("Hello");
			Console.WriteLine ("Second Line");
		}

		/* 
		 * a function can have arguments/parameters for you to pass values into
		 * like a variable they require a type and a name
		 */

		public static void DifferentMessage(string output)
		{
			Console.WriteLine("This is what you told me to output: " + output);
		}

		public static void ThirdFunction(int a, int b, int c)
		{
			int total = a + b + c;
			Console.WriteLine ("The answer is " + total);
		}

		public static void add(int a, int b)
		{
			Console.WriteLine ("Addition: " + (a + b));
		}

		public static void highest(int a, int b)
		{
			if (a > b) {
				Console.WriteLine ("Higher");
			} else if (a < b) {
				Console.WriteLine ("Lower");
			} else {
				Console.WriteLine ("Same number");
			}
		}

		public static void floatMultiply(float a, float b, float c, float d)
		{
			Console.WriteLine ("Float Multiplication: " + (a * b * c * d));
		}
	}
}
