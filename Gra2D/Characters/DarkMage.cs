using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2D.Characters
{
    class DarkMage
    {
        public int Hp { get; set; }
        public int Dmg { get; set; }

        public DarkMage()
        {
            Hp = 15;
            Dmg = 50;
        }

        public DarkMage(int hp, int dmg)
        {
            Hp = hp;
            Dmg = dmg;
        }

        public int Attack()
        {
            return -Dmg;
        }
    }
}
