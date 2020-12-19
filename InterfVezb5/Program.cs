using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb5
{
    class Program
    {
        static void Main(string[] args)
        {
            //U glavnom programu je potrebno kreirati po jedan objekat za svaku klasu ali preko instance 
            //interfejsa.Takođe je potrebno nad objektom pozvati i implementirane metode za obim, površinu, 
            //kao i metodu ToString.

            IFigura kv = new Kvadrat(5);
            kv.obim();
            kv.povrsina();
            Console.WriteLine(kv.ToString());
            //-------------------------------
            IFigura pr = new Pravougaonik(4, 5);
            pr.obim();
            pr.povrsina();
            Console.WriteLine(pr.ToString());
            //-------------------------------
            IFigura kr = new Krug(6);
            kr.obim();
            kr.povrsina();
            Console.WriteLine(kr.ToString());
            //-------------------------------
            IFigura tr = new Trougao(3);
            tr.obim();
            tr.povrsina();
            Console.WriteLine(tr.ToString());

            Console.ReadLine();
        }
    }
}
