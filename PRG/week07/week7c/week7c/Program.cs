using System;

namespace week7c
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] testArray = null;
			SetupArray (5, ref testArray, 10);

			for (int index = 0; index < testArray.Length; ++index) {
				Console.WriteLine (testArray [index]);
			}

			Console.WriteLine ("Total: {0}", Total (testArray));
			Console.WriteLine ("Last Element: {0}", LastEl (testArray));
			Console.WriteLine ("First Element: {0}", FirstEl (testArray));
			Console.WriteLine ("Average: {0}", Average (testArray));
			Console.WriteLine ("Highest: {0}", Highest (testArray));
			Console.WriteLine ("Lowest: {0}", Lowest (testArray));
		}

		public static void SetupArray(int startSize, ref int[] array, int defaultNumber)
		{
			array = new int[startSize];
			for (int index = 0; index < array.Length; ++index) {
				array [index] = defaultNumber;
			}
		}

		public static int Total (int[] array)
		{
			int total = 0;
			for (int index = 0; index < array.Length; ++index) {
				total += array [index];
			}

			return total;
		}

		public static int LastEl (int[] array) {
			return array[array.Length - 1];
		}

		public static int FirstEl (int[] array) {
			return array[0];
		}

		public static int Average (int[] array) {
			int total = 0;
			for (int index = 0; index < array.Length; ++index) {
				total += array [index];
			}

			return total / array.Length;
		}

		public static int Highest (int[] array) {
			int highest = array[0];
			for (int i = 0; i < array.Length; ++i) {
				if (array [i] > highest) {
					highest = array [i];
				}
			}
			return highest;
		}

		public static int Lowest (int[] array) {
			int lowest = array[0];
			for (int i = 0; i < array.Length; ++i) {
				if (array [i] < lowest) {
					lowest = array [i];
				}
			}
			return lowest;
		}
	}
}
