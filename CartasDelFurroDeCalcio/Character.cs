﻿using System;

namespace CartasDelFurroDeCalcio
{
	public class Character : Card
	{
		//ap=AttackPoints 
		//rp=ResistPoints
		int ap, rp;

		public int Ap { get => ap; set => ap = value; }
		public int Rp { get => rp; set => rp = value; }

		Affinity affinity;
		public Affinity Affinity {  get=> Affinity; }


		Equipment[] equip = new Equipment[3];
		int maxEquip = 3;
		int actualEquip;
		Random rand = new Random();
		public Character(string name,Rarity rarity, int cp, Affinity affinity, int ap, int rp)
		{
			this.name = name == ""? "MissingNo" : name;
			this.rarity = rarity == Rarity.None ? Rarity.Common : rarity;
			this.cp = cp == 0 ? 1 : cp;
			this.ap = ap==0? 1:cp;
			this.rp = rp==0?1:cp;
			InitEquip();

		}

		void AddEQuip()
		{
			while (actualEquip != maxEquip)
			{
				//Ni idea si esto se añade aquí
			}
		}

		void InitEquip()
		{
			for (int i = 0; i < equip.Length; i++)
			{
				equip[i] = null;
			}
		}
	}
}

