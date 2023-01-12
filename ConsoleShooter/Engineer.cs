using System;
using Weapons.Interfaces;

public class Engineer
{
	public void Repair(IRepairable weapon)
	{
		Task.Run(() => weapon.Repair());
	}

	public void Upgrade(IUpgradable weapon)
	{
		Task.Run(() => weapon.UpgradeDamage());
	}
}
