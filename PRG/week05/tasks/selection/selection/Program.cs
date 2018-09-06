using System;

namespace selection
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string USERNAME = "emiliokyp";
			string PASSWORD = "password";

			string username = Console.ReadLine ();
			string password = Console.ReadLine ();

			if (username == USERNAME) {
				if (password == PASSWORD) {
					Console.WriteLine ("Login successful");
				} else {
					Console.WriteLine ("Login unsuccessful");
				}
			} else {
				Console.WriteLine ("Username does not exist");
			}

		}
	}
}
