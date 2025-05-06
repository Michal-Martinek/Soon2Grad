using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morse_zadani
{
    internal class Program
    {
        static string zakoduj(string vstup, string sep="/", string wordEnds=" .,?!") {
            string[] morzeovka = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            vstup = vstup.ToUpper();
            string vystup = "";
            for (int i = 0; i < vstup.Length; i++) {
                char znak = vstup[i];
                if ((znak >= 'A') && (znak <= 'Z')) {
                    vystup += morzeovka[znak - 65] + sep;
                } else if (wordEnds.Contains(znak)) vystup += sep;
            }
            while (vystup.Length >= 3 && vystup.Substring(vystup.Length - 3) != sep + sep + sep) { // assert proper message end flag "///"
                vystup += sep;
            }
            return vystup;
        }
        static void Main(string[] args)
        {
            
            //místo vstupního řetězce použijte vstupní soubor vstup.txt
            //pro práci se souborem můžete použít třídu File a metodu ReadAllText pro načtení textu
            //a metodu WriteAllText pro zapsání zakódovaného textu do vystupniho souboru vystup.txt
            //ošetřete vstup/výstup

            string vstup = "SOS jak se mas?"; // default

            string path = "vstup.txt";
            // path = "vstup_err.txt"; // errorneous path
            try {
                vstup = File.ReadAllText(path);
            } catch (Exception e) {
                Console.WriteLine("Čtení souboru '{0}' se nezdařilo: {1}\n--> Používám defaultní vstup\n", path, e.Message);
            }

            Console.WriteLine("KÓDUJI VSTUP: {0}\n", vstup);
            string vystup = zakoduj(vstup);

            string vystupPath = "vystup.txt";
            try {
                Console.WriteLine(vystup);
                File.WriteAllText(vystupPath, vystup);
                // throw new FileNotFoundException("Couldnt read file: " + vystupPath);
            } catch (Exception e) {
                Console.WriteLine("\nVyjímka při zápisu do souboru '{0}':\n{1}", vystupPath, e.Message);
            }
            
            Console.ReadKey();

        }
    }
}
