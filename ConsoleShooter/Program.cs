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

        var t1 = Task.Run(() => gunslinger.Hit(kunai));
        var t2 = Task.Run(() => gunslinger.Hit(machete));
        Task.WaitAll(t1, t2);

        var t3 = Task.Run(() => gunslinger.Throw(shuriken));
        var t4 = Task.Run(() => gunslinger.Throw(kunai));
        Task.WaitAll(t3, t4);

        gunslinger.Shoot(machineGun);
        gunslinger.FireBurst(machineGun);

        var t5 = Task.Run(() => gunslinger.Shoot(sniperRiffle));
        var t6 = Task.Run(() => gunslinger.Recharge(machineGun));
        Task.WaitAll(t5, t6);

        engineer.Upgrade(machineGun);
        engineer.Repair(kunai);

        gunslinger.Recharge(machineGun);
    }
}