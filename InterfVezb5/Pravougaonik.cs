using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb5
{
    class Pravougaonik : IFigura
    {
        private int duzina;
        private int sirina;

        public Pravougaonik (int duz, int sir)
        {
            duzina = duz;
            sirina = sir;
        }

        public float obim()
        {
            return (duzina * 2) + (sirina * 2);
        }
        public float povrsina()
        {
            return duzina * sirina;
        }

        public override string ToString()
        {
            return "Pravougaonik sa stranicama " + duzina + " i " + sirina + " ima obim " + obim() + " i povrsinu " + povrsina() + ".";
        }
    }
}
