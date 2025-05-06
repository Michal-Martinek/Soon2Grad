using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zlomky_osetreni_vstupu
/*V přiloženém programu, který pracuje se zlomky, proveďte ošetření vstupu.
 Pokud uživatel zadá jiné než přípustné hodnoty, program bude požadovat,
aby uživatel zadal vstupní hodnoty znovu.
Můžete modifikovat jen metodu ZadaniZlomku(). 
Vysvětlete základní programovací techniky, které jsou v programu použity.*/

{
    
    /// <summary>
    /// třída pro práci se zlomky
    /// </summary>
    class Zlomek
    {
        public int Citatel { get; private set; }
        private int jmenovatel;
        public int Jmenovatel
        {
            get { return jmenovatel; }

            private set
            {
                if (value == 0)
                    throw new DivideByZeroException("0 nemůže být ve jmenovateli.");
                else if (value < 0)
                {

                    jmenovatel = -value;
                    Citatel *= -1;
                }

                else jmenovatel = value;
            }
        }
        public Zlomek(int c, int j)
        {
            Citatel = c;
            Jmenovatel = j;
        }

        /// <summary>
        /// Euklidův algoritmus pro výpočet největšího společného dělitele
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private int Nsd(int x, int y)//
        {
            int zbytek;
            while (y != 0)
            {
                zbytek = x % y;
                x = y;
                y = zbytek;
            }
            return x;
        }
        /// <summary>
        /// převede zlomek na základní tvar
        /// </summary>
        public void ZakladniTvar()
        {
            int zkrat = Nsd(Citatel, Jmenovatel);
            Citatel /= zkrat;
            Jmenovatel /= zkrat;

        }
        /// <summary>
        /// výpis zlomku
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Citatel}/{Jmenovatel}";

        /// <summary>
        /// přetížený operátor +
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static Zlomek operator +(Zlomek z1, Zlomek z2)
        {
            Zlomek z3 = new Zlomek(z2.Citatel * z1.Jmenovatel + z1.Citatel * z2.Jmenovatel, z2.Jmenovatel * z1.Jmenovatel);
            z3.ZakladniTvar();
            return z3;
        }

        /// <summary>
        /// unární operátor minus
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Zlomek operator -(Zlomek x)
        {
            return new Zlomek(-x.Citatel, x.Jmenovatel);
        }

        /// <summary>
        /// binární operátor minus 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Zlomek operator -(Zlomek a, Zlomek b) => a + -b;

        /// <summary>
        /// přetížení operátoru *
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static Zlomek operator *(Zlomek z1, Zlomek z2)
        {
            Zlomek z3 = new Zlomek(z2.Citatel * z1.Citatel, z2.Jmenovatel * z1.Jmenovatel);
            z3.ZakladniTvar();
            return z3;
        }
        /// <summary>
        /// operátor dělení pro zlomky
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static Zlomek operator /(Zlomek z1, Zlomek z2)
        {
            Zlomek z3 = new Zlomek(z2.Jmenovatel * z1.Citatel, z2.Citatel * z1.Jmenovatel);
            z3.ZakladniTvar();
            return z3;
        }
    }
    class Program
    {
        static Zlomek ZadaniZlomku()
        {
            Console.Write("Zadejte čitatel celé číslo: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Zadejte jmenovatel celé číslo větší než 0: ");
            int b = int.Parse(Console.ReadLine());
            Zlomek z1 = new Zlomek(a, b);
            z1.ZakladniTvar();
            return z1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Kalkulačka zlomky***");
            string pokracovat = "ano";
            while (pokracovat == "ano")
            {
                //zadávání prvního zlomku
                Console.WriteLine("První zlomek: ");
                Zlomek z1 = ZadaniZlomku();
                Console.WriteLine(z1);
                //zadávání druhého zlomku
                Console.WriteLine("Druhý zlomek:");
                Zlomek z2 = ZadaniZlomku();
                Console.WriteLine(z2);
                bool vybrano;
                do
                {
                    //zadávání operace
                    Console.WriteLine("Zadejte operaci + - * / ");
                    vybrano = true;
                    switch (Console.ReadLine())
                    {
                        case "+":
                            Console.WriteLine("Výsledek: " + (z1 + z2));

                            break;
                        case "-":
                            Console.WriteLine("Výsledek: " + (z1 - z2));

                            break;
                        case "*":
                            Console.WriteLine("Výsledek: " + (z1 * z2));
                            break;
                        case "/":
                            Console.WriteLine("Výsledek: " + (z1 / z2));
                            break;
                        default:
                            Console.WriteLine("Neplatná operace");
                            vybrano = false;
                            break;
                    }
                } while (vybrano == false);
                Console.WriteLine("Přejete si zadat další příklad? [ano/ne]");
                pokracovat = Console.ReadLine();
            }
        }
    }
}
