using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons.Interfaces;

namespace Weapons.Classes
{
    public class Kunai : IThrowingWeapon, IMeleeWeapon
    {
        public int Damage { get; set; }
        public int Reability { get; set; }

        public Kunai(int damage)
        {
            Damage = damage;
            Reability = 100;
        }

        public void Hit()
        {
            if (Reability > 0)
            {
                Console.WriteLine($"Dealt {Damage} damage with {this.GetType().Name} blow");
                Reability -= 5;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} broken");
            }
        }
        public void Throw()
        {
            Console.WriteLine($"Dealt {Damage} damage by throwing {this.GetType().Name}");
        }
        public void Repair()
        {
            Reability += 25;
            if (Reability > 100)
            {
                Reability = 100;
            }
            Console.WriteLine($"{this.GetType().Name} is repaired");
        }
        public void UpgradeDamage()
        {
            Damage += 3;
            Console.WriteLine($"{this.GetType().Name} is upgraded");
        }
    }
}
