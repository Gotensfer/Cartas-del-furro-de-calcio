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
		public SupportSkill()
		{

		}
	}
}

