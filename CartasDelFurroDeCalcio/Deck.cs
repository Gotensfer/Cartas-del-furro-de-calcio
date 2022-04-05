using System;
using System.Collections.Generic;

public class Deck
{
	int maxCP;
	int totalCP;
    List<Card> cardsInDeck = new List<Card>();
    int charactersOnDeck;


    public int MaxCP { get => maxCP; }
	public int TotalCP { get => totalCP; set => totalCP = value; }

    public Deck()
    {
        while (TotalCP >= 0)
        {
            cardsInDeck.Add(new Character());
        }

    }
}
