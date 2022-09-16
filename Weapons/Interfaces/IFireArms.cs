using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons.Interfaces
{
    public interface IFireArms : IRepairable, IRechargeable, IUpgradable
    {
        public int Damage { get; set; }

        public void FireSingleShoot() { }
    }
}
