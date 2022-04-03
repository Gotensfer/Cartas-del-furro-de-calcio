using System;

enum TargetAttribute
{
	None,
	AP,
	RP,
	ALL
}

enum EffectType
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
	public SupportSkill()
	{

	}
}
