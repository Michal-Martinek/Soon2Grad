using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_arni_soustava_do_10
{
    class Program
    {
        
        /// <summary>
        /// testuje, jetli vstupní číslo obsahuje jen možné cifry v dané soustavě
        /// </summary>
        /// <param name="cislo">vstupní číslo</param>
        /// <param name="soustava">n-arní soustava</param>
        /// <returns>ano splňuje dané požadavky</returns>
        static bool Testcisla(int cislo, int soustava)
        {
            int cifra;
            if (cislo < 0) return false;
            do
            {
                cifra = cislo % 10;
                if (cifra >= soustava) return false;
                cislo /= 10;
            } while (cislo>0);
            return true;
        }
        /// <summary>
        /// převádí z n-ární soustavy n<10 do desítkové
        /// </summary>
        /// <param name="soustava">soustava menší než 10</param>
        /// <param name="cT">vstupní číslo</param>
        /// <returns>číslo c desítkové soustavě</returns>
        static int Prevodnik(int soustava, string cT)
        {
            int vystup = 0;
            //doprogramujte, pro efektivní výpočet použijte Hornerovo schéma
            
            return vystup;
            
        }
        static void Main(string[] args)
        {
            int soustava;
            do
            {
                Console.Clear();
                Console.WriteLine("Ze které soustavy převádíme? Zadej 2-ovou až 9-ovou soustavu ");
                //ošetření vstupu
                while (!int.TryParse(Console.ReadLine(), out soustava))
                {
                    Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
                }
            } while (soustava<2 || soustava>9);
            //soustava je ok v intervalu 2..9

            int cislo;
            string cisloText;
           
            do
            {
                Console.WriteLine("Zadejte číslo k převodu může obsahovat cifry < číslo soustavy ");
                cisloText = Console.ReadLine();
                while (!int.TryParse(cisloText, out  cislo))
                {
                    Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
                    cisloText = Console.ReadLine();
                }
            } while (!Testcisla(cislo, soustava));
           
            Console.WriteLine("Číslo v desítkové soustavě: ");
            Console.WriteLine(Prevodnik(soustava, cisloText));
            Console.ReadKey();
        }
    }
}
