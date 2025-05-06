using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seznam_obrazce
{
    class OvladaniSeznamuObrazku
    {
        SeznamObrazku obraz = new SeznamObrazku();
        public void PridejObrazec()
        {
            Console.WriteLine("Můžeš vkládat obrazec=1, čtverec=2 nebo obdélník=3");
            int volba;
            while (!int.TryParse(Console.ReadLine(), out volba) || volba > 3 || volba < 1)
                Console.WriteLine("toto není správná volba 1-3");
            switch (volba)
            {
                case 1:
                    obraz.PridejObrazek(5, 5);
                    break;
                case 2:
                    obraz.PridejObrazek(10, 1, 1);
                    break;
                case 3:
                    obraz.PridejObrazek(5, 20, 0, 0);
                    break;
                default:
                    break;
            }

            Console.WriteLine("přidáno");
        }
        public void VypisObrazu()
        {
            obraz.VypisVseObrazky();
        }
    }
}
