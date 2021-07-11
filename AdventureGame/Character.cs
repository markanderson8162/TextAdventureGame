using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
	public static class Character
	{
		public static string PunchCase()
		{
			Random rng = new Random();
			int rngRange = rng.Next(0, 3);

			switch (rngRange)
			{
				case 0:
					{
						return "Your fist pounds into Mr. Storm's face.";
						break;
					}
				case 1:
					{
						return "Your fist digs into Mr. Storm's gut.";
						break;
					}
				default:
					{
						return "Mr. Storm blocks your punch.";
						break;
					}
			}


		}

		public static string CryCase()
		{
			Random rng = new Random();
			int rngRange = rng.Next(0, 3);

			switch (rngRange)
			{
				case 0:
					{
						return "Mr. Storm's face becomes the color of a ripe tomato.";
						break;
					}
				case 1:
					{
						return "Mr. Storm becomes furious when he sees you cry.";
						break;
					}
				default:
					{
						return "A single tear beings to form in Mr. Storm's eye before he fumes with anger.";
						break;
					}
			}
		}

		public static string PeeCase()
		{
			Random rng = new Random();
			int rngRange = rng.Next(0, 3);

			switch (rngRange)
			{
				case 0:
					{
						return "Mr. Storm sniffs the air. The other students begin to plug their noses.";
						break;
					}
				case 1:
					{
						return "There is fear in Mr. Storm's eyes as he recalls the time that his own children were babies.";
						break;
					}
				default:
					{
						return "Mr. Storm begins to laugh at you but quickly remembers the janitorial staff is on vacation this week.";
						break;
					}
			}
		}

	}
}
