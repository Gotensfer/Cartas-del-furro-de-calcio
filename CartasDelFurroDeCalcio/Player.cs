using System;

namespace CartasDelFurroDeCalcio
{
	public class Player
	{
		Deck deck;
		public Deck Deck { get => deck; set => deck = value; }
		public Player()
		{
			deck = new Deck();
		}
	}
}
