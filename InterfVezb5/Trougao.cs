using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb5
{
    class Trougao : IFigura
    {
        private int stranica;

        public Trougao (int str)
        {
            stranica = str;
        }

        public float obim()
        {
            return stranica * 3;
        }
        public float povrsina()
        {
            return (float)((Math.Pow(stranica, 2) * Math.Sqrt(3)) / 4);
        }

        public override string ToString()
        {
            return "Trougao sa stranicom " + stranica + " ima obim " + obim() + " i " + " povrsinu " + povrsina() + "."; 
        }
    }
}
