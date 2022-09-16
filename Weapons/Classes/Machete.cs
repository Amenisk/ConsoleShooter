using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons.Interfaces;

namespace Weapons.Classes
{
    public class Machete : IMeleeWeapon
    {
        public int Damage { get; set; }
        public int Reability { get; set; }

        public Machete(int damage)
        {
            Damage = damage;
            Reability = 100;
        }
        public void Hit()
        {
            if (Reability > 0)
            {
                Console.WriteLine($"Dealt {Damage} damage with {this.GetType().Name} blow");
                Reability -= 7;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} broken");
            }
        }
        public void Repair()
        {
            Reability += 35;
            if (Reability > 100)
            {
                Reability = 100;
            }
            Console.WriteLine($"{this.GetType().Name} is repaired");
        }

        public void Upgradedamage()
        {
            Damage += 5;
            Console.WriteLine($"{this.GetType().Name} is upgraded");
        }
    }
}
