using System;



enum Affinity
{
    None,
    Knight,
    Undead,
    Wizard,
    ALL
}
enum CardType
{   
    None,
    Character,
    Equipment,
    SupportSkill,
    ALL
}

public abstract class Card
{
    public String name;
    public int cp;

}
