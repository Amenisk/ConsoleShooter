using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons.Interfaces;

namespace Weapons.Classes
{
    public class Shuriken : IThrowingWeapon
    {
        public int Damage { get; set; }

        public Shuriken(int damage)
        {
            Damage = damage;
        }

        public void Throw()
        {
            Console.WriteLine($"Dealt {Damage} damage by throwing {this.GetType().Name}");
        }
    }
}
