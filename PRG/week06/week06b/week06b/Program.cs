using System;

namespace week06b
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int add = Add (5, 6);
			Console.WriteLine (add);
			Console.WriteLine(readNumber ());
		}

		/*
		 * All functions have to have a return type, up until now we've used
		 * void which effectively means no return type.
		 * A return type specifies what a function should spit back out.
		 * In this first example it will return an integer which wil be the result of a sum
		 */

		public static int Add(int a, int b)
		{
			return a + b;
		}

		public static int readNumber()
		{
			int number = int.Parse(Console.ReadLine ());	
			return number;
		}

		public static int minus(int a, int b)
		{
			return a - b;
		}

		public static int minus(int a, int b)
		{
			return a * b;
		}

		public static int divide(int a, int b)
		{
			return a / b;
		}

		public static int remainder(int a, int b)
		{
			return a % b;
		}

		public static int average(int a, int b, int c, int d, int e)
		{
			return (a + b + c + d + e) / 5;
		}

		public static int returnHigher(int a, int b)
		{
			if (a > b) {
				return a;
			} else if (b > a) {
				return b;
			}
		}

		public static int returnHigher(int a, int b)
		{
			if (a < b) {
				return a;
			} else if (b < a) {
				return b;
			}
		}
	}
}
