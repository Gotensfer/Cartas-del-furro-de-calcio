using System;
using System.Collections.Generic;

namespace CartasDelFurroDeCalcio
{
	public class Character : Card
	{
		//ap=AttackPoints 
		//rp=ResistPoints
		int ap, rp, maxRP;

		public int Ap
        {
			get => ap;
            set
            {
				if (value < 0) ap = 0;
                else ap = value;
			}
        }
				
		public int Rp
        {
			get => rp;
            set
            {
				if (value < 0) rp = 0;
				else if (value > maxRP) rp = maxRP;
				else rp = value;
            }
        }
		public int MaxRP { get => maxRP; set => maxRP = value; }

		Affinity affinity;
		public Affinity Affinity { get => affinity; }

		List<Equipment> equip;
		public List<Equipment> Equip { get => equip; set => equip = value; }

		int maxEquip = 3;
		public int MaxEquip{ get => maxEquip;}

		int actualEquip;
		public int ActualEquip { get => actualEquip; }

		public Character(string name,Rarity rarity, int cp, Affinity affinity, int ap, int rp)
		{
			this.name = name == ""? "MissingNo" : name;
			this.rarity = rarity == Rarity.None ? Rarity.Common : rarity;
			this.cp = cp < 1 ? 1 : cp;
			this.affinity = affinity == Affinity.None ? Affinity.Knight : affinity == Affinity.ALL ? Affinity.Knight : affinity;
			this.ap = ap < 1 ? 1 :ap;
			this.rp = rp < 1 ? 1 :rp;
			this.maxRP = this.rp;
			this.equip = new List<Equipment>();

		}

		public void AddEQuip(Equipment equipment)
		{
			if (equip.Count < 3 && (equipment.Affinity == this.affinity || equipment.Affinity == Affinity.ALL))
            {
				equip.Add(equipment);
				equipment.ApplyEquipmentEffect(this);
            }
		}

		public void DestroyEquip(string nameOfEquipmentToDestroy)
        {
            for (int i = 0; i < equip.Count; i++)
            {
				if (Equals(equip[i].Name, nameOfEquipmentToDestroy))
				{
					equip[i].RemoveEquipmentEffect(this);
					equip.RemoveAt(i);
					// Falta remover del deck
				}
			}
        }
	}
}

