using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons.Interfaces
{
    public interface IRechargeable
    {
        public int CountOfBullets { get; set; }
        public int StorageVolume { get; set; }
        public void Recharge() { }
    }
}
