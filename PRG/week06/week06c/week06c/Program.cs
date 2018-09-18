using System;

namespace week06c
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int myNumber = 10;
			Console.WriteLine (myNumber);
			Changes (myNumber);
			Console.WriteLine (myNumber);
			KeepChanges (ref myNumber);
			Console.WriteLine (myNumber);
			KeepChanges2 (out myNumber);
			Console.WriteLine (myNumber);

			int a = 3;
			int b = 4;
			int c = 7;
			randomise (ref a, ref b, ref c);
			Console.WriteLine ("a: {0}, b: {1}, c: {2}", a, b, c);

			Console.WriteLine ("A: {0}", a);
			half (ref a);
			Console.WriteLine ("A: {0}", a);

			Console.WriteLine ("Random: {0}", randomNumber ());

			Console.WriteLine ("Enter your username");
			Console.WriteLine (username (Console.ReadLine ()));
		}


		/*
		 * By default primitive data such as int, float and bool are passed by value
		 * This means essentially a copy of the value is placed instead of the original
		 * Therefore any changes that occur in the function are lost in the end
		 */

		public static void Changes(int number)
		{
			number += 5;
			number *= 2;
		}

		public static void KeepChanges(ref int number)
		{
			number += 5;
			number *= 2;
		}

		public static void KeepChanges2 (out int number)
		{
			number = 100;
		}

		public static void randomise (ref int a, ref int b, ref int c)
		{
			var rand = new Random ();
			a = rand.Next (101);
			b = rand.Next (101);
			c = rand.Next (101);
		}

		public static void half (ref int a)
		{
			a /= 2;
		}

		public static int randomNumber()
		{
			var rand = new Random ();
			return rand.Next (-10, 10);
		}

		public static bool username (string username)
		{
			string USERNAME = "admin";
			if (username == USERNAME) {
				return true;
			} else {
				return false;
			}
		}

	}
}
