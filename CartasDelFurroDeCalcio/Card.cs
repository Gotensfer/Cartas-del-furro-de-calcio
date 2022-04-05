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
        public String name;
        public int cp;
    }
}


