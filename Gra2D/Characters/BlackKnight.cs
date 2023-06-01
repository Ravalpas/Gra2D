using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2D.Characters
{
    class BlackKnight
    {
        public int Hp { get; set; }
        public int Dmg { get; set; }

        public BlackKnight()
        {
            Hp = 25;
            Dmg = 20;
        }

        public BlackKnight(int hp, int dmg)
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
