using System;

namespace Week2b
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Console.WriteLine ("Please enter your name");
			string name = Console.ReadLine ();

			Console.WriteLine ("Welcome " + name);
			Console.ReadLine ();
			*/
			/*
			Console.WriteLine ("Username");
			var username = Console.ReadLine ();
			Console.WriteLine ("Password");
			var password = Console.ReadLine ();

			Console.Clear ();
			Console.WriteLine(String.Format("Welcome {0}!", username));
			*/

			/* Console.WriteLine ("Enter a number");
			string input = Console.ReadLine ();



		
			int parsedNum = int.Parse (input);
			int total = parsedNum + 10;

			Console.WriteLine ("Your number plus 10 is " + total);
			*/

			Console.WriteLine ("Please enter a number");
			int aParsed;
			string a = Console.ReadLine ();

			int.TryParse(a, out aParsed);

			Console.WriteLine ("Please enter another number");
			int bParsed;
			string b = Console.ReadLine ();
			int.TryParse (b, out bParsed);

			Console.WriteLine("Addition: " + (aParsed + bParsed));

			Console.WriteLine ("Please enter a number");
			a = Console.ReadLine ();
			int.TryParse (a, out aParsed);

			Console.WriteLine ("Please enter another number");
			b = Console.ReadLine ();
			int.TryParse (b, out bParsed);

			Console.WriteLine ("Multiplication: " + (aParsed * bParsed));

			Console.WriteLine ("Please enter a number");
			a = Console.ReadLine ();

			int.TryParse (a, out aParsed);

			Console.WriteLine ("Please enter another number");
			b = Console.ReadLine ();

			int.TryParse (b, out bParsed);

			Console.WriteLine ("Remainder: " + (aParsed % bParsed));

			Console.WriteLine ("Please enter a number");
			a = Console.ReadLine ();

			int.TryParse (a, out aParsed);

			Console.WriteLine ("Please enter another number");
			b = Console.ReadLine ();

			int.TryParse (b, out bParsed);

			Console.WriteLine ("Please enter another a number");
			int cParsed;
			string c = Console.ReadLine ();
			int.TryParse (c, out cParsed);

			Console.WriteLine("Average: " + ((aParsed + bParsed + cParsed) / 3));

			/*
			Console.WriteLine ("Please enter a number");
			a = int.Parse(Console.ReadLine ());
			Console.WriteLine ("Please enter another number");
			b = int.Parse(Console.ReadLine ());

			Console.WriteLine("Multiplication: " + a * b);

			Console.WriteLine ("Please enter a number");
			a = int.Parse(Console.ReadLine ());
			Console.WriteLine ("Please enter another number");
			b = int.Parse(Console.ReadLine ());

			Console.WriteLine("Remainder: " + a % b);

			Console.WriteLine ("Please enter a number");
			a = int.Parse(Console.ReadLine ());
			Console.WriteLine ("Please enter another number");
			b = int.Parse(Console.ReadLine ());
			Console.WriteLine ("Please enter another number");
			var c = int.Parse(Console.ReadLine ());

			Console.WriteLine("Average of all 3 numbers = " + (a + b + c) / 3);

		*/
		}
	}
}
