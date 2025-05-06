using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seznam_obrazce
{
    class Program
    {
        static void Main(string[] args)
        {
            OvladaniSeznamuObrazku obr = new OvladaniSeznamuObrazku();
            Console.WriteLine("Práce s obrázkem: ");
            char volba = '0';
            // hlavní cyklus
            while (volba != '3')
            {
                Console.WriteLine("____________________________");
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat obrazec");
                Console.WriteLine("2 - Vypsat všechny obrazce v obrázku");
                Console.WriteLine("3 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // reakce na volbu
                switch (volba)
                {
                    case '1':
                        obr.PridejObrazec();
                        break;
                    case '2':
                        obr.VypisObrazu();
                        break;
                    case '3':
                        Console.WriteLine("Libovolnou klávesou ukončíte program...");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}
