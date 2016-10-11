using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppFUN2
{
    public class Weapon
    {
        public int WeaponID { get; }
        public int WeaponDMG { get; }
        public int WeaponCrt { get; }
        public string WeaponName { get; }

        public Weapon(int weaponID, int weaponDMG, int weaponCrt)
        {
            WeaponID = weaponID;
            WeaponDMG = weaponDMG;
            WeaponCrt = weaponCrt;
        }
    }
}
