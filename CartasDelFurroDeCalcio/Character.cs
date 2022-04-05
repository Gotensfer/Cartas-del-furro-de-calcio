using System;

public class Character : Card
{
	//ap=AttackPoints 
	//rp=ResistPoints
	int ap, rp;
	Equipment[] equip = new Equipment[3];

	Affinity affinity;
	int maxEquip = 3;
	int actualEquip;
	Random rand = new Random();
	public Character()
	{
		name = "Jueputimus el hijueputiador";
		cp = ap = rand.Next(1, 6);
		ap = rand.Next(1, 6);
		rp = rand.Next(1, 6);
		InitEquip();

	}

	void AddEQuip()
    {
        while (actualEquip!=maxEquip)
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
