using Microsoft.VisualStudio.TestTools.UnitTesting;
using CartasDelFurroDeCalcio;
using System.Linq;

namespace PruebasUnitarias
{
    [TestClass]
    public class DeckFunctionality
    {
        [TestMethod] // # 1
        public void CreatedDeck_Has_DefinedMaxCP() 
        {
            // Vector de prueba: 
            const int expectedDeckCP = 40;

            // - Crear un deck
            Deck deck = new Deck();

            // - Comparar el CP máximo del Deck con el CP esperado
            // - Si el CP máximo del Deck es igual al CP esperado se pasa la prueba

            Assert.AreEqual(deck.MaxCP, expectedDeckCP);
        }

        [TestMethod] // #3
        public void DeckHasCardLimits()
        {
            // Vector de prueba
            const int expectedDeck_CharacterCardCount = 5;
            const int expectedDeck_EquipCardCount = 10;
            const int expectedDeck_SupportSkillCardCont = 5;

            // - Crear un deck 
            Deck deck = new Deck();

            // - Meter 7 cartas de tipo Character en el deck
            for (int i = 0; i < 6; i++)
            {
                Character character = new Character("", Rarity.None, 0, Affinity.None, 0, 0);
                deck.AddCard(character);
            }

            // - Meter 12 cartas de tipo Equipent en el deck
            for (int i = 0; i < 11; i++)
            {
                Equipment equipment = new Equipment("", Rarity.None, 0, Affinity.None, TargetAttribute.None, 0);
                deck.AddCard(equipment);
            }

            // - Meter 8 cartas de tipo SupportSkill en el deck
            for (int i = 0; i < 7; i++)
            {
                SupportSkill supportSkill = new SupportSkill("", Rarity.None, 0, EffectType.None, 0);
                deck.AddCard(supportSkill);
            }

            // - Comparar
            Assert.AreEqual(expectedDeck_CharacterCardCount, deck.CardsInDeck.OfType<Character>().Count());
            Assert.AreEqual(expectedDeck_EquipCardCount, deck.CardsInDeck.OfType<Equipment>().Count());
            Assert.AreEqual(expectedDeck_SupportSkillCardCont, deck.CardsInDeck.OfType<SupportSkill>().Count());
        }
    }

    [TestClass] 
    public class BaseCard
    {
        [TestMethod] // # 2
        public void AllCardTypes_Has_BasicChacteristics() 
        {
            // Vector de prueba: 
            const string notExpectedName = "";
            const Rarity notExpectedRarity = Rarity.None;
            const int notExpectedCP = 0;

            // - Crear cartas "vacias" de los 3 tipos
            Character character0 = new Character("", Rarity.None, 0, Affinity.None, 0, 0);
            Equipment equipment0 = new Equipment("", Rarity.None, 0, Affinity.None, TargetAttribute.None, 0);
            SupportSkill supportSkill0 = new SupportSkill("", Rarity.None, 0, EffectType.None, 0);

            // - Crear una carta "estandar" de los 3 tipos
            Character character1 = new Character("Name0", Rarity.Common, 1, Affinity.Knight, 1, 1);
            Equipment equipment1 = new Equipment("Name1", Rarity.Rare, 1, Affinity.Knight, TargetAttribute.AP, 1);
            SupportSkill supportSkill1 = new SupportSkill("Name2", Rarity.SuperRare, 1, EffectType.ReduceRP, 1);

            // - Comparar el name, rarity y cp de la carta una de las cartas estandar con los vectores de prueba
            Assert.AreNotEqual(character0.Name, notExpectedName);
            Assert.AreNotEqual(character0.Rarity, notExpectedRarity);
            Assert.AreNotEqual(character0.Cp, notExpectedCP);

            Assert.AreNotEqual(equipment0.Name, notExpectedName);
            Assert.AreNotEqual(equipment0.Rarity, notExpectedRarity);
            Assert.AreNotEqual(equipment0.Cp, notExpectedCP);

            Assert.AreNotEqual(supportSkill0.Name, notExpectedName);
            Assert.AreNotEqual(supportSkill0.Rarity, notExpectedRarity);
            Assert.AreNotEqual(supportSkill0.Cp, notExpectedCP);

            // - Comparar el name, rarity y cp de la carta una de las cartas estandar con los vectores de prueba
            Assert.AreNotEqual(character1.Name, notExpectedName);
            Assert.AreNotEqual(character1.Rarity, notExpectedRarity);
            Assert.AreNotEqual(character1.Cp, notExpectedCP);

            Assert.AreNotEqual(equipment1.Name, notExpectedName);
            Assert.AreNotEqual(equipment1.Rarity, notExpectedRarity);
            Assert.AreNotEqual(equipment1.Cp, notExpectedCP);

            Assert.AreNotEqual(supportSkill1.Name, notExpectedName);
            Assert.AreNotEqual(supportSkill1.Rarity, notExpectedRarity);
            Assert.AreNotEqual(supportSkill1.Cp, notExpectedCP);

            // - Si se satisfacen los vectores de prueba se pasa la prueba
        }
    }

    [TestClass]
    public class CharacterCardFunctionality
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }

    [TestClass]
    public class EquipCardFunctionality
    {
        [TestMethod]
        public void Test()
        {

        }
    }

    [TestClass]
    public class SupportSkillCardFunctionality
    {
        [TestMethod]
        public void test2()
        {

        }
    }
}
