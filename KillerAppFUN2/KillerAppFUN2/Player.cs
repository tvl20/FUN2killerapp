using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppFUN2
{
    public class Player : Entity
    {
        public Weapon Weapon;
        public string Name { get; private set; }
        public int Defence { get; set; }
        public Player(Point location, string name, int lvl, int defence, int maxhp, int hp, Direction d, Weapon w, int roomID) : base(location, d, lvl, maxhp, hp, roomID)
        {
            Name = name;
            Defence = defence;
            Weapon = w;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
