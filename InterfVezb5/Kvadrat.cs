using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb5
{
    class Kvadrat : IFigura
    {
        private int stranica;

        public Kvadrat (int str)
        {
            stranica = str;
        }

        public float obim()
        {
            return stranica * 4;
        }

        public float povrsina()
        {
            return stranica * stranica;
        }
        public override string ToString()
        {
            return "Kvadrat sa stranicom " + stranica + " ima obim " + obim() + " i povrsinu " + povrsina() + ".";
        }
    }
}
