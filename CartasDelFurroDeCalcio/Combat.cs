using System;
using System.Linq;
namespace CartasDelFurroDeCalcio
{
	public class Combat
	{
		Player player1;
		public Player Player1 { get => player1;}

		Player player2;
		public Player Player2 { get => player2;}
	public Combat()
		{

		}

		void Fight(Character char1, Character char2)
		{
			char1.Rp -= char2.Ap;
			char2.Rp -= char1.Ap;
            if (char1.Rp <= 0)
            {
				Console.WriteLine("Character 1 destruido");
				char1 = null;
            }
			if (char2.Rp <= 0)
			{
				Console.WriteLine("Character 2 destruido");
				char2 = null;
			}
		}
		void Win(Player player1, Player player2)
		{
			if (player1.Deck.CardsInDeck.OfType<Character>().Count() == 0)
			{
				Console.WriteLine("Ganador jugador 2");
				player1 = null;
			}
			if(player2.Deck.CardsInDeck.OfType<Character>().Count() == 0)
					{
				Console.WriteLine("Ganador jugador 1");
				player2 = null;
			}
		}
	}
}
