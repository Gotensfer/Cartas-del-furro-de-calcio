using System;

namespace CartasDelFurroDeCalcio
{
    public enum Affinity
    {
        None,
        Knight,
        Undead,
        Wizard,
        ALL
    }
    public enum CardType
    {
        None,
        Character,
        Equipment,
        SupportSkill,
        ALL
    }
    public enum Rarity
    {
        None,
        Common,
        Rare,
        SuperRare,
        UltraRare
    }

    public abstract class Card
    {
        protected string name;
        protected int cp;
        protected Rarity rarity;

        public string Name { get => name; }
        public int Cp { get => cp; }
        public Rarity Rarity { get => rarity; }
    }
}


