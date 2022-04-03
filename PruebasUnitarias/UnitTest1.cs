using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }

    [TestClass] 
    public class BaseCard
    {
        [TestMethod] // # 2
        public void AllCardTypes_Has_BasicChacteristics() 
        {
            // Vector de prueba: 
            const string notExpectedName = "";
            const int notExpectedRarity = 0;
            const int notExpectedCP = 0;

            // - Crear una carta de Character
            // - Crear una carta de Equip
            // - Crear una carta de Support skill

            // - Comparar el name, rarity y cp de la carta una de las cartas con los vectores de prueba
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
