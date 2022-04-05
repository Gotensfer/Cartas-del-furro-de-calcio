using System;

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
			this.name = name;
			this.rarity = rarity;
			this.cp = cp;
			this.ap = ap;
			this.rp = rp;
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

