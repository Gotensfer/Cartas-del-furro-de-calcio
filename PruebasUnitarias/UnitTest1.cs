using Microsoft.VisualStudio.TestTools.UnitTesting;
using CartasDelFurroDeCalcio;
using System.Linq;

namespace PruebasUnitarias
{
    [TestClass]
    public class DeckFunctionality
    {
        [TestMethod] // #1
        public void CreatedDeck_Has_DefinedMaxCP() 
        {
            // Vector de prueba: 
            const int expectedDeckCP = 40;

            // - Crear un deck
            Deck deck = new Deck();

            // - Comparar el CP m�ximo del Deck con el CP esperado
            // - Si el CP m�ximo del Deck es igual al CP esperado se pasa la prueba

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

        [TestMethod] // #11
        public void CanAddCardAsLongAsCPRemainingAllowsIt()
        {
            Character ch1 = new Character("Ch", Rarity.Common, 2, Affinity.Knight, 1, 1);

            // Caso #1 La carta a agregar reducira el CP normalmente
            const int c1_expectedDeckTotalCP = 38;

            Deck deck1 = new Deck();
            deck1.AddCard(ch1);

            Assert.AreEqual(c1_expectedDeckTotalCP, deck1.TotalCP);

            // Caso #2 La carta a agregar reduciria el CP por debajo de 0
            const int c2_expectedDeckTotalCP = 1;

            Deck deck2 = new Deck();
            deck2.TotalCP = 1;
            deck2.AddCard(ch1);

            Assert.AreEqual(c2_expectedDeckTotalCP, deck2.TotalCP);   
        }
    }

    [TestClass] 
    public class BaseCard
    {
        [TestMethod] // #2
        public void AllCardTypes_Has_BasicChacteristics() 
        {
            // Vector de prueba #1 Caso de creaci�n vacio
            const string notExpectedName = "";
            const Rarity notExpectedRarity = Rarity.None;
            const int notExpectedCP = 0;

            // Vector de prueba #2 Caso de creaci�n normal
            const string expectedName = "RandomName";
            const Rarity expectedRarity = Rarity.Rare;
            const int expectedCP = 2;

            // - Crear cartas "vacias" de los 3 tipos
            Character character0 = new Character("", Rarity.None, 0, Affinity.None, 0, 0);
            Equipment equipment0 = new Equipment("", Rarity.None, 0, Affinity.None, TargetAttribute.None, 0);
            SupportSkill supportSkill0 = new SupportSkill("", Rarity.None, 0, EffectType.None, 0);

            // - Crear una carta "estandar" de los 3 tipos
            Character character1 = new Character("RandomName", Rarity.Rare, 2, Affinity.Knight, 1, 1);
            Equipment equipment1 = new Equipment("RandomName", Rarity.Rare, 2, Affinity.Knight, TargetAttribute.AP, 1);
            SupportSkill supportSkill1 = new SupportSkill("RandomName", Rarity.Rare, 2, EffectType.ReduceRP, 1);

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
            Assert.AreEqual(character1.Name, expectedName);
            Assert.AreEqual(character1.Rarity, expectedRarity);
            Assert.AreEqual(character1.Cp, expectedCP);

            Assert.AreEqual(equipment1.Name, expectedName);
            Assert.AreEqual(equipment1.Rarity, expectedRarity);
            Assert.AreEqual(equipment1.Cp, expectedCP);

            Assert.AreEqual(supportSkill1.Name, expectedName);
            Assert.AreEqual(supportSkill1.Rarity, expectedRarity);
            Assert.AreEqual(supportSkill1.Cp, expectedCP);
        }
    }

    [TestClass]
    public class CharacterCardFunctionality
    {
        [TestMethod] // #4
        public void CorrectInitialization()
        {
            // Vector de prueba #1 - Caso de creaci�n vac�a
            const Affinity notExpectedAffinity = Affinity.None;
            const int notExpectedAP = 0;
            const int notExpectedRP = 0;

            // - Crear una carta de porky con los campos propios vac�os
            Character duque = new Character("Duque", Rarity.UltraRare, 1, Affinity.None, 0, 0);

            Assert.AreNotEqual(notExpectedAffinity, duque.Affinity);
            Assert.AreNotEqual(notExpectedAP, duque.Ap);
            Assert.AreNotEqual(notExpectedRP, duque.Rp);

            // Vector de prueba #2 - Caso de creaci�n normal
            const Affinity expectedAffinity = Affinity.Wizard;
            const int expectedAP = 5;
            const int expectedRP = 8;

            // - Crear una carta del todopoderoso Gio con los campos propios definidos
            Character gio = new Character("Gio", Rarity.UltraRare, 6, Affinity.Wizard, 5, 8);

            Assert.AreEqual(expectedAffinity, gio.Affinity);
            Assert.AreEqual(expectedAP, gio.Ap);
            Assert.AreEqual(expectedRP, gio.Rp);
        }

        [TestMethod]
        public void EquipCardLimit() // #7
        {
            // Vector de prueba
            const int expectedAmountOfEquipCards = 3;

            Character character = new Character("RandomName", Rarity.Common, 1, Affinity.Knight, 1, 1);

            //Intentar equipar 4 equipments
            for (int i = 0; i < 4; i++)
            {
                Equipment equipment = new Equipment("RandomEquipment", Rarity.Common, 1, Affinity.Knight, TargetAttribute.AP, 1);
                character.AddEQuip(equipment);
            }

            Assert.AreEqual(expectedAmountOfEquipCards, character.Equip.Count);
        }

        [TestMethod] // #12
        public void FaceCharacterFunctionality()
        {
            // Caso #1 Ambos characters se enfrentan pero ninguno es destruido
            const int ch1_expectedFinalRP = 1;
            const int ch2_expectedFinalRP = 4;

            Character ch1 = new Character("Ch1", Rarity.Common, 2, Affinity.Knight, 2, 4);
            Character ch2 = new Character("Ch2", Rarity.Common, 2, Affinity.Knight, 3, 6);

            Combat combat = new Combat();

            combat.Fight(ch1, ch2);
            Assert.AreEqual(ch1_expectedFinalRP, ch1.Rp);
            Assert.AreEqual(ch2_expectedFinalRP, ch2.Rp);


            //Caso #1 Ambos characters se enfrentan y uno es destruido
            const string final_expectedResult = "Character 1 destruido";

            string result = combat.Fight(ch1, ch2);

            Assert.AreEqual(final_expectedResult, result);

        }
    }

    [TestClass]
    public class EquipCardFunctionality
    {
        [TestMethod] // #5
        public void CorrectInitialization()
        {
            // Vector de prueba #1 - Caso de creaci�n vac�a
            const Affinity notExpectedAffinity = Affinity.None;
            const TargetAttribute notExpectedTarget = TargetAttribute.None;
            const int notExpectedEffectPoints = 0;

            Equipment tituloDePresidencia = new Equipment("Titulo de presidencia", Rarity.SuperRare, 1, Affinity.None, TargetAttribute.None, 0);

            Assert.AreNotEqual(notExpectedAffinity, tituloDePresidencia.Affinity);
            Assert.AreNotEqual(notExpectedTarget, tituloDePresidencia.TargetAttribute);
            Assert.AreNotEqual(notExpectedEffectPoints, tituloDePresidencia.EffectPoints);

            // Vector de prueba #2 - Caso de creaci�n normal
            const Affinity expectedAffinity = Affinity.Wizard;
            const TargetAttribute expectedTarget = TargetAttribute.ALL;
            const int expectedEffectPoints = 4;

            Equipment discordDeGio = new Equipment("Discord de Gio", Rarity.SuperRare, 2, Affinity.Wizard, TargetAttribute.ALL, 4);

            Assert.AreEqual(expectedAffinity, discordDeGio.Affinity);
            Assert.AreEqual(expectedTarget, discordDeGio.TargetAttribute);
            Assert.AreEqual(expectedEffectPoints, discordDeGio.EffectPoints);
        }

        [TestMethod]
        public void AffinityMatch_Functionality() // #8
        {
            // Equipamientos de todos los tipos
            Equipment eqKn = new Equipment("eqKn", Rarity.Common, 1, Affinity.Knight, TargetAttribute.AP, 2);
            Equipment eqWi = new Equipment("eqWi", Rarity.Common, 1, Affinity.Wizard, TargetAttribute.RP, 4);
            Equipment eqUn = new Equipment("eqUn", Rarity.Common, 1, Affinity.Undead, TargetAttribute.ALL, 8);

            //Caso #1 A�adir cada tipo de equipo a Knight
            const int c1_expectedFinalAP = 4;
            const int c1_expectedFinalRP = 5;

            Character knight = new Character("Knight", Rarity.Common, 4, Affinity.Knight, 2, 5);
            knight.AddEQuip(eqKn);
            knight.AddEQuip(eqWi);
            knight.AddEQuip(eqUn);

            Assert.AreEqual(c1_expectedFinalAP, knight.Ap);
            Assert.AreEqual(c1_expectedFinalRP, knight.Rp);

            //Caso #2 A�adir cada tipo de equipo a Wizard
            const int c2_expectedFinalAP = 6;
            const int c2_expectedFinalRP = 6;

            Character wizard = new Character("Wizard", Rarity.Common, 4, Affinity.Wizard, 6, 2);
            wizard.AddEQuip(eqKn);
            wizard.AddEQuip(eqWi);
            wizard.AddEQuip(eqUn);


            Assert.AreEqual(c2_expectedFinalAP, wizard.Ap);
            Assert.AreEqual(c2_expectedFinalRP, wizard.Rp);

            //Caso #3 A�adir cada tipo de equipo a Undead
            const int c3_expectedFinalAP = 12;
            const int c3_expectedFinalRP = 14;

            Character undead = new Character("Undead", Rarity.Common, 4, Affinity.Undead, 4, 6);
            undead.AddEQuip(eqKn);
            undead.AddEQuip(eqWi);
            undead.AddEQuip(eqUn);

            Assert.AreEqual(c3_expectedFinalAP, undead.Ap);
            Assert.AreEqual(c3_expectedFinalRP, undead.Rp);
        }

        [TestMethod] 
        public void TargetAttribute_Functionality() // #9
        {
            // Caso #1 A�adir un equipment con target en AP
            const int c1_expectedFinalAP = 3;
            const int c1_expectedFinalRP = 4;

            Character ch1 = new Character("Ch1", Rarity.Common, 4, Affinity.Knight, 1, 4);
            Equipment eqAP = new Equipment("eqAP", Rarity.Common, 1, Affinity.Knight, TargetAttribute.AP, 2);
            ch1.AddEQuip(eqAP);

            Assert.AreEqual(c1_expectedFinalAP, ch1.Ap);
            Assert.AreEqual(c1_expectedFinalRP, ch1.Rp);

            // Caso #2 A�adir un equipment con target en RP
            const int c2_expectedFinalAP = 4;
            const int c2_expectedFinalRP = 8;

            Character ch2 = new Character("Ch2", Rarity.Common, 4, Affinity.Knight, 4, 5);
            Equipment eqRP = new Equipment("eqRP", Rarity.Common, 1, Affinity.Knight, TargetAttribute.RP, 3);
            ch2.AddEQuip(eqRP);

            Assert.AreEqual(c2_expectedFinalAP, ch2.Ap);
            Assert.AreEqual(c2_expectedFinalRP, ch2.Rp);

            // Caso #3 A�adir un equipment con target en ALL
            const int c3_expectedFinalAP = 12;
            const int c3_expectedFinalRP = 14;

            Character ch3 = new Character("Ch3", Rarity.Common, 4, Affinity.Knight, 2, 4);
            Equipment eqALL = new Equipment("eqALL", Rarity.Common, 1, Affinity.Knight, TargetAttribute.ALL, 10);
            ch3.AddEQuip(eqALL);

            Assert.AreEqual(c3_expectedFinalAP, ch3.Ap);
            Assert.AreEqual(c3_expectedFinalRP, ch3.Rp);
        }
    }

    [TestClass]
    public class SupportSkillCardFunctionality
    {
        [TestMethod]
        public void CorrectInitialization() // #6
        {
            // Vector de prueba #1 - Caso de creaci�n vac�a

            const EffectType notExpectedEType = EffectType.None;
            const int notExpectedEffectPoints = 0;

            SupportSkill estupidez = new SupportSkill("Titulo de presidencia", Rarity.Common, 1, EffectType.None, 0);

            Assert.AreNotEqual(notExpectedEType, estupidez.EffectType);
            Assert.AreNotEqual(notExpectedEffectPoints, estupidez.EffectPoints);

            // Vector de prueba #2 - Caso de creaci�n normal
     
            const EffectType expectedEType = EffectType.RestoreRP;
            const int expectedEffectPoints = 5;

            SupportSkill partiditaDeLol = new SupportSkill("Discord de Gio", Rarity.SuperRare, 3, EffectType.RestoreRP, 5);

            Assert.AreEqual(expectedEType, partiditaDeLol.EffectType);
            Assert.AreEqual(expectedEffectPoints, partiditaDeLol.EffectPoints);

            // Vector de prueba #3 - Caso de creaci�n de EffectType en DestroyEquipment
            const EffectType expectedETypeDE = EffectType.DestroyEquipment;
            const int expectedEffectPointsDE = 0;

            //Crear un supportSkill de destroyEquipment con Effects points imposibles
            SupportSkill cancelarleLaMateria = new SupportSkill("Cancelarle la materia", Rarity.Rare, 4, EffectType.DestroyEquipment, 2);

            Assert.AreEqual(expectedETypeDE, cancelarleLaMateria.EffectType);
            Assert.AreEqual(expectedEffectPointsDE, cancelarleLaMateria.EffectPoints);
        }

        [TestMethod] // #10
        public void EffectType_Functionality()
        {
            SupportSkill spAP = new SupportSkill("spAP", Rarity.Common, 2, EffectType.ReduceAP, 2);
            SupportSkill spRP = new SupportSkill("spRP", Rarity.Common, 2, EffectType.ReduceRP, 2);
            SupportSkill spALL = new SupportSkill("spALL", Rarity.Common, 2, EffectType.ReduceAll, 2);
            SupportSkill spResRP = new SupportSkill("spResRP", Rarity.Common, 2, EffectType.RestoreRP, 2);
            SupportSkill spDE = new SupportSkill("spDE", Rarity.Common, 2, EffectType.DestroyEquipment, 0);

            // Caso #1 Agregar SP de tipo ReduceAP
            const int c1_expectedFinalAP = 2;
            const int c1_expectedFinalRP = 4;

            Character c1 = new Character("c1", Rarity.Common, 1, Affinity.Knight, 4, 4);

            spAP.ApplyEffect(c1);
            Assert.AreEqual(c1_expectedFinalAP, c1.Ap);
            Assert.AreEqual(c1_expectedFinalRP, c1.Rp);

            // Caso #2 Agregar SP de tipo ReduceRP
            const int c2_expectedFinalAP = 4;
            const int c2_expectedFinalRP = 2;

            Character c2 = new Character("c2", Rarity.Common, 1, Affinity.Knight, 4, 4);

            spRP.ApplyEffect(c2);
            Assert.AreEqual(c2_expectedFinalAP, c2.Ap);
            Assert.AreEqual(c2_expectedFinalRP, c2.Rp);

            // Caso #3 Agregar SP de tipo ReduceALL
            const int c3_expectedFinalAP = 2;
            const int c3_expectedFinalRP = 2;

            Character c3 = new Character("c3", Rarity.Common, 1, Affinity.Knight, 4, 4);

            spALL.ApplyEffect(c3);
            Assert.AreEqual(c3_expectedFinalAP, c3.Ap);
            Assert.AreEqual(c3_expectedFinalRP, c3.Rp);

            // Caso #4 Agregar SP de tipo RestoreRP
            const int c4_expectedFinalAP = 4;
            const int c4_expectedFinalRP = 4;

            Character c4 = new Character("c4", Rarity.Common, 1, Affinity.Knight, 4, 4);

            spRP.ApplyEffect(c4);
            spResRP.ApplyEffect(c4);
            Assert.AreEqual(c4_expectedFinalAP, c4.Ap);
            Assert.AreEqual(c4_expectedFinalRP, c4.Rp);

            // Caso #1 Agregar SP de tipo DestroyEquipment
            const int c5_expectedFinalAP = 4;
            const int c5_expectedFinalRP = 4;
            const int c5_expectedEquipmentAmount = 0;

            Character c5 = new Character("c5", Rarity.Common, 1, Affinity.Knight, 4, 4);
            Equipment eq = new Equipment("ARandomEquip", Rarity.Common, 1, Affinity.Knight, TargetAttribute.RP, 3);

            c5.AddEQuip(eq);
            spAP.ApplyEffect(c5, "ARandomEquip");
            Assert.AreEqual(c5_expectedFinalAP, c5.Ap);
            Assert.AreEqual(c5_expectedFinalRP, c5.Rp);
            Assert.AreEqual(c5_expectedEquipmentAmount, c5.Equip.Count);
        }
    }
}

