using System;
using Weapons.Interfaces;

public class Engineer
{
	public void Repair(IRepairable weapon)
	{
		weapon.Repair();
	}

	public void Upgrade(IUpgradable weapon)
	{
		weapon.UpgradeDamage();
	}
}
