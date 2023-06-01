using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2D.Characters
{
    class SuspectedBunny
    {
        public int Hp { get; set; }
        public int Dmg { get; set; }

        public SuspectedBunny()
        {
            Hp = 15;
            Dmg = 5;
        }

        public SuspectedBunny(int hp, int dmg)
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
