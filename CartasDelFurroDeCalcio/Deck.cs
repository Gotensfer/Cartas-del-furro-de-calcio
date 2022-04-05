using System;
using System.Collections.Generic;

namespace CartasDelFurroDeCalcio
{
    public class Deck
    {
        int maxCP;
        int totalCP;
        List<Card> cardsInDeck = new List<Card>();

        public List<Card> CardsInDeck { get => cardsInDeck; set => cardsInDeck=value; }

        int charactersOnDeck;
        public int CharactersOnDeck { get => charactersOnDeck; set => charactersOnDeck=value; }


        public int MaxCP { get => maxCP; }
        public int TotalCP { get => totalCP; set => totalCP = value; }

        public Deck()
        {
            maxCP = 40;


        }
    }
}

