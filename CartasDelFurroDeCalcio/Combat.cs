using System;
using System.Linq;
using System.Data.Common;

namespace CartasDelFurroDeCalcio
{
	public class Combat
	{
		Player player1;
		public Player Player1 { get => player1; set => player1 = value; }

		Player player2;
		public Player Player2 { get => player2; set => player2 = value; }

		public Combat()
		{
			player1 = null;
			player2 = null;
		}

		public string Fight(Character char1, Character char2)
		{
			char1.Rp -= char2.Ap;
			char2.Rp -= char1.Ap;
			if (char1.Rp <= 0)
			{
				Console.WriteLine("Character 1 destruido");
				return "Character 1 destruido";

			}
			else if (char2.Rp <= 0)
			{
				Console.WriteLine("Character 2 destruido");
				return "Character 2 destruido";
			}
            else
            {
				return "";
            }
		}
	}

}
