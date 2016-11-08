using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppFUN2.DAL
{
    class WeaponBizLog
    {
        private IWeaponRepo repo;

        public WeaponBizLog(IWeaponRepo _repo)
        {
            repo = _repo;
        }

        public List<Weapon> getAllWeapons()
        {
            return repo.getAllWeapons();
        }

        public Weapon getWeapon(string name)
        {
            return repo.getWeapon(name);
        }
    }
}
