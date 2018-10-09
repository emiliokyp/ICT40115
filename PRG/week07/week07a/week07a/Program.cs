using System;

namespace week07a
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 * An array is used to group related data together.
			 * This ca make things like looping very easy.
			 * They use [] brackets and have an index to refer
			 * To which section or 'element' refer to.
			 * 
			 * eg animal[3] = "Cat"; this is the 4 element/index
			 * of an array called animal. Note: Indexes start at 0 not 1
			 * 3 is the index
			 * Cat is the element
			 */

			string[] animal = new string[5];
			animal [0] = "Rat";
			animal [1] = "Ant";
			animal [2] = "Dog";
			animal [3] = "Walrus";
			animal [4] = "Whale";


			Console.WriteLine ("The first animal is {0}", animal [0]);
			Console.WriteLine ("The third animal is {0}", animal [4]);

			animal [1] = "Viper";
			Console.WriteLine ("The animal at index 1 has changed to {0}", animal [1]);

			int i = 2;
			Console.WriteLine ("The element at index {0} is {1}", i, animal [i]);

			// ask the user to enter a number between 0 and 4, output the element at that index
			// check if its within those bounderies and ask again if they aren't

			i = -1;
			while (i > 4 || i < 0) {
				Console.WriteLine ("Please enter a number between 0 and 4");
				i = GetNumber ();
			}
			Console.WriteLine ("The animal at index {0} is {1}", i, animal [i]);


		}

		public static int GetNumber()
		{
			return int.Parse (Console.ReadLine ());
		}
	}
}
