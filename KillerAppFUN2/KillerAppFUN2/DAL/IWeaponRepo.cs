﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppFUN2.DAL
{
    interface IWeaponRepo
    {
        List<Weapon> getAllWeapons();
        Weapon getWeapon(string name);
    }
}
