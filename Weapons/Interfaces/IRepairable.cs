using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons.Interfaces
{
    public interface IRepairable
    {
        public int Reability { get; set; }
        public void Repair();
    }
}
