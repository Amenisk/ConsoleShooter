using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons.Interfaces;

namespace Weapons.Classes
{
    public class SniperRiffle : IFireArms
    {
        public int Damage { get; set; }
        public int Reability { get; set; }
        public int CountOfBullets { get; set; }
        public int StorageVolume { get; set; }

        public SniperRiffle(int damage, int storageVolume)
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
                    Reability -= 3;
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
        public void UpgradeDamage()
        {
            Damage += 7;
            Console.WriteLine($"{this.GetType().Name} is upgraded");
        }
        public void Repair()
        {
            Reability += 20;
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
