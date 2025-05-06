using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seznam_obrazce
{
    class SeznamObrazku
    {
        List<Bod> obrazky = new List<Bod>();
        public void PridejObrazek(float x, float y)
        {
            obrazky.Add(new Bod(x, y));
        }
        public void PridejObrazek(float a, float x, float y)
        {
            obrazky.Add(new Ctverec(a, x, y));
        }
        public void PridejObrazek(float a, float b, float x, float y)
        {
            obrazky.Add(new Obdelnik(a, b, x, y));
        }

        public void VypisVseObrazky()
        {
            Console.WriteLine("_________________________");
            foreach (Bod o in obrazky)
            {
                Console.WriteLine(o.Info());
            }
        }
    }
}
