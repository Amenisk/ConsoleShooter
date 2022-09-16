using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons.Interfaces;

namespace Weapons.Classes
{
    public class MachineGun : IAutomaticWeapon
    {
        public int Damage { get; set; }
        public int Reability { get; set; }
        public int CountOfBullets { get; set; }
        public int StorageVolume { get; set; }

        public MachineGun(int damage, int storageVolume)
        {
            Damage = damage;
            StorageVolume = storageVolume;
            CountOfBullets = storageVolume;
            Reability = 100;
        }

        public void FireSingleShoot()
        {
            if (Reability > 0)
            {
                if (CountOfBullets > 0)
                {
                    Console.WriteLine($"Shot from {this.GetType().Name} " +
                        $"caused {Damage} damage");
                    Reability -= 2;
                    CountOfBullets--;
                }
                else
                {
                    Recharge();
                    FireSingleShoot();
                }  
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} broken");
            }
        }
        public void FireBurst()
        {
            if (Reability > 0)
            {
                if (CountOfBullets > 4)
                {
                    Console.WriteLine($"Burst of shots from " +
                        $"{this.GetType().Name} caused {Damage * 3} damage");
                    Reability -= 7;
                    CountOfBullets -= 5;
                }
                else
                {
                    Recharge();
                    FireSingleShoot();
                }
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} is broken");
            }
        }
        public void UpgradeDamage()
        {
            Damage += 5;
            Console.WriteLine($"{this.GetType().Name} is upgraded");
        }
        public void Repair()
        {
            Reability += 30;
            if (Reability > 100)
            {
                Reability = 100;
            }

            Console.WriteLine($"{this.GetType().Name} is repaired");
        }
        public void Recharge()
        {
            CountOfBullets = StorageVolume;
            Console.WriteLine($"{this.GetType().Name} is recharged");
        }
    }
}
