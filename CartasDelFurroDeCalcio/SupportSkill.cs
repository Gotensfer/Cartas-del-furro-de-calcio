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
		public int EffectPoints { get => effectPoints; set => effectPoints = value; }

		EffectType effectType;
		public EffectType EffectType { get => effectType; }
		public SupportSkill(string name,Rarity rarity, int cp,EffectType effectType, int effectPoints)
		{
			this.name = name == "" ? "Garra de la muerte ignea" : name;
			this.rarity = rarity == Rarity.None ? Rarity.Common : rarity;
			this.cp = cp < 1 ? 1 : cp;
			this.effectType = effectType==EffectType.None?EffectType.ReduceAP:effectType;
			this.effectPoints = effectType == EffectType.DestroyEquipment ? 0 : effectPoints < 1 ? 1 : effectPoints;
		}
	}
}

