﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons.Interfaces
{
    public interface IAutomaticWeapon : IFireArms
    {
        public void FireBurst() { }
    }
}
