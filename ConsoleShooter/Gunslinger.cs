using System;
using Weapons.Interfaces;

public class Gunslinger
{
	public void Shoot(IFireArms weapon)
	{
		weapon.FireSingleShoot();
	}
	public void FireBurst(IAutomaticWeapon weapon)
	{
		weapon.FireBurst();
	}
	public void Hit(IMeleeWeapon weapon)
	{
		weapon.Hit();
	}
	public void Throw(IThrowingWeapon weapon)
	{
		weapon.Throw();
	}
	public void Recharge(IRechargeable weapon)
	{
		weapon.Recharge();
	}
}
