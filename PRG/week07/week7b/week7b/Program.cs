using System;

namespace week7b
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] numbers = new int[10];
			Random rand = new Random ();

			for (int i = 0; i < numbers.Length; ++i) {
				numbers [i] = rand.Next (101);
			}

			Console.WriteLine ("{0}\n{1}\n{2}", numbers[0], numbers [2], numbers[numbers.Length - 1]);

			Console.WriteLine ("Please enter a number");
			int length = GetNumber ();
			Console.Clear ();
			var userArray = new int[length];

			for (int i = 0; i < length; ++i) {
				Console.WriteLine ("Please enter a number for index {0}", i);
				userArray [i] = GetNumber ();
				Console.Clear ();
			}
				
			Console.WriteLine ("All elements in array:");

			for (int i = 0; i < length; ++i) {
				Console.WriteLine (userArray [i]);
			}

			int index = 0;
			for (index = 0; index < int.MaxValue; ++index) {

			}
			Console.WriteLine (index);

		}

		public static int GetNumber()
		{
			return int.Parse (Console.ReadLine ());
		}
	}
}
