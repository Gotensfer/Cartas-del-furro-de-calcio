using System;
using System.Collections.Generic;
using System.Linq;

namespace CartasDelFurroDeCalcio
{
    public class Deck
    {
        int maxCP;
        int totalCP;
        List<Card> cardsInDeck;

        public List<Card> CardsInDeck { get => cardsInDeck; set => cardsInDeck=value; }

        int charactersOnDeck;
        public int CharactersOnDeck { get => charactersOnDeck; set => charactersOnDeck=value; }

        int maxCharactersInDeck = 5;
        int maxEquipmentsnDeck = 10; 
        int maxSupportSkillsInDeck = 5;

        public int MaxCP { get => maxCP; }
        public int TotalCP { get => totalCP; set => totalCP = value; }

        public Deck()
        {
            maxCP = 40;
            totalCP = maxCP;
            cardsInDeck = new List<Card>();
        }

        public void AddCard(Card card)
        {
            if (card is Character && cardsInDeck.OfType<Character>().Count() < maxCharactersInDeck && card.Cp <= this.totalCP)
            {
                cardsInDeck.Add(card);
                this.totalCP -= card.Cp;
            }
            if (card is Equipment && cardsInDeck.OfType<Equipment>().Count() < maxEquipmentsnDeck && card.Cp <= this.totalCP)
            {
                cardsInDeck.Add(card);
                this.totalCP -= card.Cp;
            }
            else if (card is SupportSkill && cardsInDeck.OfType<SupportSkill>().Count() < maxSupportSkillsInDeck && card.Cp <= this.totalCP)
            {
                cardsInDeck.Add(card);
                this.totalCP -= card.Cp;
            }
        }

    }
}

