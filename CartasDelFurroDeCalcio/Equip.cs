﻿using System;

namespace CartasDelFurroDeCalcio
{
	public class Equipment : Card
	{
		int effectPoints;
		public int Ap { get => effectPoints; set => effectPoints = value; }

		TargetAttribute targetAttribute;
		public TargetAttribute TargetAttribute { get => targetAttribute; }

		Affinity affinity;
		public Affinity Affinity { get => Affinity; }
		public Equipment(string name, Rarity rarity, int cp, Affinity affinity,TargetAttribute targetAttribute, int effectPoints)
		{

		}
	}
}

