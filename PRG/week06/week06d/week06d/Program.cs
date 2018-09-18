using System;

namespace week06d
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int cash = 100;
			int player = 0;
			int dealer = 0;

			Console.WriteLine ("How much would you like to bet?");
			int bet = GetNumber ();
			while (player < 21 && dealer < 21) {
	
				if (cash >= bet) {
					
					string input = Console.ReadLine ();
					if (input != "s") {
						Console.WriteLine ("Hit or stand?");
						if (input == "h") {
							hit (ref player, "player");
						} else {
							if (dealer < 15) {
								hit (ref dealer, "dealer");
							} else {
								ChooseWinner (player, dealer);
								break;
							}
						}
					}
				} else {
					Console.WriteLine ("You don't have enough money...");
					break;
				}

		
			}
			ChooseWinner(player, dealer);

		}


		public static int GetNumber() 
		{
			int n = 0;
			try {
				n = int.Parse(Console.ReadLine ());	
			} catch (Exception ex) {
				Console.WriteLine ("Invalid input:" + ex);
			}
			return n;
		}

		public static void hit (ref int person, string name)
		{
			var rand = new Random ();
			person += rand.Next (1, 11);
			Console.WriteLine ("New {0} score: {1}", name, person);
		}

		public static void ChooseWinner(int player, int dealer) {
			if (dealer > player && dealer <= 21)
				Console.WriteLine ("Dealer won");
			else if (dealer < player && player <= 21)
				Console.WriteLine ("Player won");
		}
	
		
	}
}
