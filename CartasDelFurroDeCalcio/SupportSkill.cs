using System;

namespace CartasDelFurroDeCalcio
{
	public enum TargetAttribute
	{
		None,
		AP,
		RP,
		ALL
	}

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
			this.name = name;
			this.rarity = rarity;
			this.cp = cp;
			this.effectType = effectType;
			this.effectPoints = effectPoints;

		}
	}
}

