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
	public class Equipment : Card
	{
		int effectPoints;
		public int EffectPoints { get => effectPoints; set => effectPoints = value; }

		TargetAttribute targetAttribute;
		public TargetAttribute TargetAttribute { get => targetAttribute; }

		Affinity affinity;
		public Affinity Affinity { get => affinity; }
		public Equipment(string name, Rarity rarity, int cp, Affinity affinity,TargetAttribute targetAttribute, int effectPoints)
		{
			this.name = name == "" ? "Agonía de escarcha" : name;
			this.rarity = rarity == Rarity.None ? Rarity.Common : rarity;
			this.cp = cp < 1 ? 1 : cp;
			this.affinity = affinity == Affinity.None ? Affinity.Knight : affinity;
			this.targetAttribute = targetAttribute == TargetAttribute.None ? TargetAttribute.AP : targetAttribute;
			this.effectPoints = effectPoints < 1 ? 1 : effectPoints;

		}
	}
}

