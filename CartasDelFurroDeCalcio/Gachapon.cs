using System;
using System.Collections.Generic;
using System.Text;

namespace CartasDelFurroDeCalcio
{

    public class Gachapon
    {

        Random _random = new Random();

        public Gachapon()
        {

            RandomRarity(RandomType());

        }

        CardType RandomType()
        {   float yourCard = _random.Next(1, 101);

            if (yourCard <= 20)
            {
                CardType ct = CardType.Character;
                Console.WriteLine("Tipo de carta Character");
                return ct;
            }
            else if (yourCard <= 51)
            {
                CardType eq = CardType.Equipment;
                Console.WriteLine("Tipo de carta Equipment");
                return eq;
            }
            else
            {
                CardType ss = CardType.SupportSkill;
                Console.WriteLine("Tipo de carta SupportSkill");
                return ss;
            }

            Console.WriteLine(yourCard);
    
            yourCard = 0;
        }
        //perdón ya está muy tarde no me da la sanidad mental y quiero agua no nos rebaje pls xdxdxdxd
        void RandomRarity(CardType cardType)
        {
            
            switch (cardType)
            {
                case CardType.Character:
                    float yourCard = _random.Next(1, 21);
                    if (yourCard <= 1)
                    {
                        Rarity rarity = Rarity.UltraRare;
                        Console.WriteLine("Tipo de UR");
                    }
                    else if (yourCard <= 6)
                    {
                        Rarity rarity = Rarity.SuperRare;
                        Console.WriteLine("Tipo de carta SR");
                    }
                    else if (yourCard <= 10)
                    {
                        Rarity rarity = Rarity.Rare;
                        Console.WriteLine("Tipo de carta R");
                    }
                    else if (yourCard <= 20)
                    {
                        Rarity rarity = Rarity.Common;
                        Console.WriteLine("Tipo de carta C");
                    }

                    break;
                case CardType.Equipment:
                     yourCard = _random.Next(21, 51);
                    if (yourCard <= 21)
                    {
                        Rarity rarity = Rarity.UltraRare;
                        Console.WriteLine("Tipo de UR");
                    }
                    else if (yourCard <= 27)
                    {
                        Rarity rarity = Rarity.SuperRare;
                        Console.WriteLine("Tipo de carta SR");
                    }
                    else if (yourCard <= 33)
                    {
                        Rarity rarity = Rarity.Rare;
                        Console.WriteLine("Tipo de carta R");
                    }
                    else if (yourCard <= 51)
                    {
                        Rarity rarity = Rarity.Common;
                        Console.WriteLine("Tipo de carta C");
                    }
                    break;
                case CardType.SupportSkill:
                    yourCard = _random.Next(51, 101);
                    if (yourCard <= 51)
                    {
                        Rarity rarity = Rarity.UltraRare;
                        Console.WriteLine("Tipo de UR");
                    }
                    else if (yourCard <= 57)
                    {
                        Rarity rarity = Rarity.SuperRare;
                        Console.WriteLine("Tipo de carta SR");
                    }
                    else if (yourCard <= 63)
                    {
                        Rarity rarity = Rarity.Rare;
                        Console.WriteLine("Tipo de carta R");
                    }
                    else if (yourCard <= 100)
                    {
                        Rarity rarity = Rarity.Common;
                        Console.WriteLine("Tipo de carta C");
                    }
                    break;

                default:
                    break;

                    
            }
        }
    }
}