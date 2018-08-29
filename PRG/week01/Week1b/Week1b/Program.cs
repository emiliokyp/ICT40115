using System;

namespace Week1b
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a = 1;
			int b = 5;
			int c = -30;

			a = a + 1;
			a += 1;

			Console.WriteLine (a);

			a -= 1;

			a *= 4;

			a /= 2;

			Console.WriteLine (a);

			a = 10;
			int remainder = a % 3;
			Console.WriteLine (remainder);

			int days = 700;
			int years = days / 365;
			int daysLeftover = days % 365;

			Console.WriteLine ("in " + days + " days there is " + years + " year/s and " + daysLeftover + " days remainder");

			a = 4;
			b = 10;
			c = -3;

			// 40
			// -8
			// 77
			// -26

			int total = a * b;
			Console.WriteLine (total);
			total = a + a * c;
			Console.WriteLine (total);
			total = (b + b) * a + c;
			Console.WriteLine (total);
			total = a + a - a + c * b;
			Console.WriteLine (total);
				
			int data = 0;
			data++; // This is postfix, the increase happens at the end of use;
			Console.WriteLine (data);
			++data; // This is prefix, the increase happens before use;
			Console.WriteLine (data);
			data++;
			++data;
			Console.WriteLine (++data);
			Console.WriteLine (data++);
			Console.WriteLine (data);


			// 5
			// 12
			// 6
			// 10

			total = ++a;
			Console.WriteLine (total);
			total = a++ + ++a;
			Console.WriteLine (total);
			total = b + --c;
			Console.WriteLine (total);
			total = a + b++ - c + b;
			Console.WriteLine (total);
		}
	}
}
