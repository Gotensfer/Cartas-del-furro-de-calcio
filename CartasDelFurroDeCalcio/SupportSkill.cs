using System;

namespace CartasDelFurroDeCalcio
{
	public enum EffectType
	{
		None,
		ReduceAP,
		ReduceRP,
		ReduceAll,
		DestroyEquipment,
		RestoreRP
	}

	public class SupportSkill : Card
	{
		int effectPoints;
		public int Ap { get => effectPoints; set => effectPoints = value; }

		EffectType effectType;
		public EffectType EffectType { get => effectType; }
		public SupportSkill(string name,Rarity rarity, int cp,EffectType effectType, int effectPoints)
		{
			this.name = name == "" ? "Garra de la muerte ignea" : name;
			this.rarity = rarity == Rarity.None ? Rarity.Common : rarity;
			this.cp = cp == 0 ? 1 : cp;
			this.effectType = effectType==EffectType.None?EffectType.ReduceAP:effectType;
			this.effectPoints = effectPoints == 0 ? 1 : effectPoints;

		}
	}
}

