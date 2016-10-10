using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppFUN2
{
    public abstract class Entity
    {
        public enum Direction
        {
            North,
            South,
            East,
            West
        }
        public Point Location { get; set; }
        public int MaxHP { get; set; }
        public int HP { get; set; }
        public Direction Dir { get; set; }
        public int Level { get; set; }

        public Entity(Point location, Direction d, int lvl, int maxhp, int hp)
        {
            Location = location;
            Dir = d;
            Level = lvl;
            MaxHP = maxhp;
            HP = hp;
        }
    }
}
