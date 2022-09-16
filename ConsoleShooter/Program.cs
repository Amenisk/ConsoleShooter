using System;
using Weapons.Classes;

class Program
{
    static void Main()
    {
        Gunslinger gunslinger = new Gunslinger();
        Engineer engineer = new Engineer();
        Kunai kunai = new Kunai(15);
        Machete machete = new Machete(20);
        MachineGun machineGun = new MachineGun(15, 35);
        Shuriken shuriken = new Shuriken(10);
        SniperRiffle sniperRiffle = new SniperRiffle(35, 10);

        gunslinger.Hit(kunai);
        gunslinger.Hit(machete);
        gunslinger.Throw(shuriken);
        gunslinger.Throw(kunai);
        gunslinger.Shoot(sniperRiffle);
        gunslinger.Shoot(machineGun);
        gunslinger.FireBurst(machineGun);

        engineer.Upgrade(machineGun);
        engineer.Repair(kunai);

        gunslinger.Shoot(machineGun);
        gunslinger.Recharge(machineGun);
    }
}