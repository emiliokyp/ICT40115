using System;

namespace week05d
{
	class MainClass
	{

		enum Command {Attack, Defend}

		public static void Main (string[] args)
		{
			/* Create a battle arena betwen a player and an ai
			 * They should have attack, defense and health
			 * They can choose to attack or defend (random for ai)
			 * These should be stored in an enum.
			 * If attacking and the opponent defends the result is
			 * target health -= (attack - defense)
			 * if both parties attack it's health -= attack
			 * if both defend its a draw
			 * loop until someone is defeated and then announce the winner and their remaining health
			 */

	
			int player_health = 100;
			int player_attack = 40;
			int player_defense = 10;
			Command player_style = Command.Attack;

			int ai_health = 100;
			int ai_attack = 30;
			int ai_defense = 20;
			Array values = Enum.GetValues(typeof(Command));
			Random random = new Random();

			while (ai_health > 0 && player_health > 0) {
				// generate random style for ai
			Command ai_style = (Command)values.GetValue(random.Next(values.Length));
				//get user input and convert to int
			Console.WriteLine ("1: Attack\n2: Defend");
			int input = int.Parse(Console.ReadLine ());
				// determine which attack style player has chosen
			switch (input) {
				case 1:
					player_style = Command.Attack;
					break;
				case 2:
					player_style = Command.Defend;
					break;
				default:
					Console.WriteLine ("Invalid input");
					break;
				}

				if (player_style == ai_style) {
					Console.WriteLine ("The round was a draw");
					player_health -= ai_attack;
					ai_health -= player_attack;
					Console.WriteLine ("D to AI: {0}", player_attack);
					Console.WriteLine ("D to Player: {0}", ai_attack);
				} else if (player_style == Command.Attack && ai_style == Command.Defend) {
					ai_health -= (player_attack - ai_defense);
					Console.WriteLine ("You won the round!");
					Console.WriteLine ("D: {0}", player_attack - ai_defense);
				} else if (player_style == Command.Defend && ai_style == Command.Attack) {
					player_health -= (ai_attack - player_defense);
					Console.WriteLine ("The AI won the round!");
					Console.WriteLine ("D: {0}", player_attack - ai_defense);
				}

				Console.WriteLine ("AI HEALTH: {0}\nYOUR HEALTH: {1}", ai_health, player_health);

			}

			if (ai_health > player_health) {
				Console.WriteLine ("The AI won the game :(");
			} else {
				Console.WriteLine ("You won the game!!!");
			}

		}
	}
}
