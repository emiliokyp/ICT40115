using System;

namespace Week2a
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("This is week2 revision");

			int number = 10;
			int value = -1000;
			int aBigNumber = 99999999;

			float x = 9.453f;
			float y = -45.34f;

			bool canFly = false;
			bool isNetworkReady = true;
			bool downloadCompleted = false;

			string name = Console.ReadLine ();
			string colour = "Red";
			string username = "emiliokyp";

			Console.WriteLine (name);
			Console.WriteLine("The variable value has " + value + " stored");

			int a = 10;
			int b = 5;

			int total = a + b;
			Console.WriteLine (a + " + " + b + " = " + total);
			Console.WriteLine (String.Format ("{0} + {1} = {2}", a, b, total));
            
			Console.ReadLine ();
		}
	}
}
