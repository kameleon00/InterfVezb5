using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb5
{
    class Krug : IFigura
    {
        private int poluprecnik;
        public const float PI = 3.14f;

        public Krug(int r)
        {
            poluprecnik = r;
        }

        public float obim()
        {
            return 2 * poluprecnik * PI;
        }
        public float povrsina()
        {
            return (poluprecnik * poluprecnik) * PI;
        }
        public override string ToString()
        {
            return "Krug sa poluprecnikom " + poluprecnik + " ima obim " + obim() + " i povrsinu " + povrsina() + ".";
        }
    }
}
