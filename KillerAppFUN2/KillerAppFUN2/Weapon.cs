using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppFUN2
{
    public class Weapon
    {
        private int WeaponID { get; set; }
        public int WeaponDMG { get; set; }
        public int WeaponCrt { get; set; }

        public Weapon(int weaponID, int weaponDMG, int weaponCrt)
        {
            WeaponID = weaponID;
            WeaponDMG = weaponDMG;
            WeaponCrt = weaponCrt;
        }
    }
}
