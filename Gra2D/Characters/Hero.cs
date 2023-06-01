using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2D.Characters
{
    class Hero
    {
        public int Hp { get; set; }
        public int Dmg { get; set; }

        public Hero()
        {
            Hp = 30;
            Dmg = 5;
        }
        public Hero(int hp, int dmg)
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
