using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obousmerny_seznam_uvod {
    class Program {
        static void Naplneni(ref LinkedList<int> s, int pocet, int rozsah) {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 1; i <= pocet; i++) {
                s.AddLast(rand.Next(0, rozsah));
            }
        }

        static void Vypis1(ref LinkedList<int> s) {
            Console.WriteLine("Vypis 1:");
            foreach (int i in s) Console.Write("{0}, ", i);
            Console.WriteLine();
            // Console.ReadKey();
        }

        static void Vypis2(ref LinkedList<int> s) {
            //pruchod seznamem druhý zbůsob
            Console.WriteLine("Vypis 2:");
            LinkedListNode<int> pom = s.First;
            for (int i = 1; i <= s.Count; ++i) {
                Console.Write("{0}, ", pom.Value);
                pom = pom.Next;
            }
            Console.WriteLine();
            // Console.ReadKey();
        }

        static void Vypis3(ref LinkedList<int> s) {
            //pruchod seznamem třetí zbůsob
            Console.WriteLine("Vypis 3:");
            LinkedListNode<int> pom = s.First;
            while (pom != null) {
                Console.Write("{0}, ", pom.Value);
                pom = pom.Next;
            }
            Console.WriteLine();
            // Console.ReadKey();
        }
        // dopište sami ------------------------------------
        static double Prumer(ref LinkedList<int> s)
        {
            Int64 sum = 0; int count = 0;
            LinkedListNode<int> pom = s.First;
            while (pom != null) {
                ++count;
                sum += pom.Value;
                pom = pom.Next;
            }
            return (double)sum / count;
        }
        
        static int Maximum(ref LinkedList<int> s)
        {
            int max = int.MinValue;
            LinkedListNode<int> pom = s.First;
            while (pom != null) {
                max = max < pom.Value ? pom.Value : max;
                pom = pom.Next;
            }
            return max;
        }

        static int Minimum(ref LinkedList<int> s)
        {
            int min = int.MaxValue;
            LinkedListNode<int> pom = s.First;
            while (pom != null) {
                min = min > pom.Value ? pom.Value : min;
                pom = pom.Next;
            }
            return min;
        }

        static void VypisPozpatku(ref LinkedList<int> s) {
            Console.Write("Pozpatku: ");
            LinkedListNode<int> pom = s.Last;
            while (pom != null) {
                Console.Write("{0}, ", pom.Value);
                pom = pom.Previous;
            }
        }

        static void Otoceni(ref LinkedList<int> s, ref LinkedList<int> o) {
        /// ze seznamu s vytvoří nový seznam o, který bude mít prvky v obráceném pořadí
            while (s.Count != 0) {
                int v = s.First.Value;
                s.RemoveFirst();
                o.AddFirst(v);
            }
        }
        
        static void CopyAll(ref LinkedList<int> from, ref LinkedList<int> to) {
            LinkedListNode<int> pom = from.First;
            while (pom != null) {
                int v = pom.Value;
                to.AddLast(v);
                pom = pom.Next;
            }
        }
        static void SpojeniZasebou(ref LinkedList<int> s1, ref LinkedList<int> s2, ref LinkedList<int> s3)
        //spojí dva seznamy s1 a s2 za sebou do seznamu s3
        {
            CopyAll(ref s1, ref s3);
            CopyAll(ref s2, ref s3);
        }

        static void SpojeniCikCak(ref LinkedList<int> s, ref LinkedList<int> prvni, ref LinkedList<int> druhy)
            //spojí dva seznamy prvni a druhy cik cak do seznamu s, nejsou-li seznamy stejně dlouhé zbytek dokopíruje
        {
            LinkedListNode<int> pom1 = prvni.First;
            LinkedListNode<int> pom2 = druhy.First;

            while (pom1 != null || pom2 != null) {
                if (pom1 != null) {
                    s.AddLast(pom1.Value);
                    pom1 = pom1.Next;
                }
                if (pom2 != null) {
                    s.AddLast(pom2.Value);
                    pom2 = pom2.Next;
                }
            }
        }

        


        // static void RozdelLichaSuda(ref LinkedList<int> s, ref LinkedList<int> suda, ref LinkedList<int> licha) {
            static void RozdelPodleModula(ref LinkedList<int> s, params LinkedList<int>[] modules) {
            // Rozdělení seznamu na střídačku do jednotlivých seznamů podle zbytků při dělení počtem seznamů (=> tedy na lichá, sudá při dvou seznamech)
            LinkedListNode<int> pom = s.First;
            while (pom != null) {
                modules[pom.Value % modules.Length].AddLast(pom.Value);
                pom = pom.Next;
            }
        }


        static void RozdelMalaVelka(ref LinkedList<int> s, ref LinkedList<int> mala, ref LinkedList<int> velka) {
            // Rozdělení seznamu na základě průměru
            double prumer = Prumer(ref s);
            LinkedListNode<int> pom = s.First;
            while (pom != null) {
                if (pom.Value <= prumer) {
                    mala.AddLast(pom.Value); // menší nebo rovno průměru
                } else {
                    velka.AddLast(pom.Value); // Velké nad průměrem
                }
                pom = pom.Next;
            }
        }

        static void RozdelPrvniDruhy(ref LinkedList<int> s, ref LinkedList<int> prvni, ref LinkedList<int> druhy) {
        //rozdělí seznam s na dva seznamy prvni druhy
            while (s.Count != 0) {
		prvni.AddLast(s.First.Value);
                s.EraseFirst();
		if (s.Count != 0) {
			druhy.AddLast(s.First.Value);
                	s.EraseFirst();
		}
            }
	}

        static void SpojeniUsp(ref LinkedList<int> s1, ref LinkedList<int> s2, ref LinkedList<int> s3)
        //Dva uspořádané lineární seznamy s1, s2 spojte do jednoho uspořádaného seznamu s3.
        {
            LinkedListNode<int> pom1 = s1.First, pom2 = s2.First;
            while (pom1 != null || pom2 != null) {
                if (pom1 != null && (pom2 == null || pom1.Value <= pom2.Value)) { // určitě musíme mít pom1, a zároveň buď nemáme pom2 nebo je pom1 menší z těch dvou
                    s3.AddLast(pom1.Value);
                    pom1 = pom1.Next;
                } else {
                    s3.AddLast(pom2.Value);
                    pom2 = pom2.Next;
                }
            }
        }
        static void VlozeniUsp(ref LinkedList<int> s, int prvek) {
        // Vložení prvku do uspořádaného seznamu.
            LinkedListNode<int> pom = s.First;
            while (pom != null && pom.Value < prvek) {
                pom = pom.Next;
            }

            if (pom == null) {
                s.AddLast(prvek); // Přidání na konec
            } else {
                s.AddBefore(pom, prvek); // Přidání před nalezený prvek
            }
        }


        static void Main(string[] args) {
            /*Vytvořte lineární spojový seznam o 20 prvcích náhodně generovaných celých čísel v intervalu <0..100>.*/

            LinkedList<int> spojak = new LinkedList<int>();
            Naplneni(ref spojak, 10, 100);
            Vypis1(ref spojak);


            spojak.AddFirst(1);
            spojak.AddFirst(2);
            Console.WriteLine(spojak.Min());
            spojak.Average();

            Vypis2(ref spojak);

            Vypis1(ref spojak);
            Vypis2(ref spojak);
            Vypis3(ref spojak);

            spojak.AddLast(5);
            spojak.AddLast(6);
            Vypis1(ref spojak);

            Console.WriteLine(spojak.First.Value);
            Console.WriteLine(spojak.First.Next.Value);
            // Console.ReadKey();
            LinkedListNode<int> pom;
            pom = spojak.First.Next;//ukazatel na 2.prvek

            spojak.AddAfter(pom, 50);// přidáná za 2. prvek
            spojak.AddBefore(pom, 100);// přidáná před 2. prvek
            Vypis1(ref spojak);

            spojak.RemoveFirst();
            spojak.RemoveLast();
            Vypis1(ref spojak);

            spojak.Remove(5);
            Vypis1(ref spojak);

            // ------------------------------------------------
            // 5. Prumer
            double prumer = Prumer(ref spojak);
            Console.WriteLine($"Průměr: {prumer}");

            // 6. Maximum
            int max = Maximum(ref spojak);
            Console.WriteLine($"Maximum: {max}");

            // 7. Minimum
            int min = Minimum(ref spojak);
            Console.WriteLine($"Minimum: {min}");

            // 8. Vypis pozpatku
            VypisPozpatku(ref spojak);

            // 9. Otoceni
            LinkedList<int> otoceny = new LinkedList<int>();
            Otoceni(ref spojak, ref otoceny);
            Vypis1(ref otoceny);

            // 10. CopyAll
            LinkedList<int> kopie = new LinkedList<int>();
            CopyAll(ref spojak, ref kopie);
            Vypis2(ref kopie);

            // 11. SpojeniZasebou
            LinkedList<int> dalsiSeznam = new LinkedList<int>();
            Naplneni(ref dalsiSeznam, 5, 100);
            Vypis3(ref dalsiSeznam);

            LinkedList<int> spojenySeznam = new LinkedList<int>();
            SpojeniZasebou(ref spojak, ref dalsiSeznam, ref spojenySeznam);
            Vypis1(ref spojenySeznam);

            // 12. SpojeniCikCak
            LinkedList<int> prvni = new LinkedList<int>();
            LinkedList<int> druhy = new LinkedList<int>();
            Naplneni(ref prvni, 3, 50);
            Naplneni(ref druhy, 3, 50);
            Vypis2(ref prvni);
            Vypis3(ref druhy);

            LinkedList<int> cikCakSeznam = new LinkedList<int>();
            SpojeniCikCak(ref cikCakSeznam, ref prvni, ref druhy);
            Vypis1(ref cikCakSeznam);

            // 13. RozdelLichaSuda
            LinkedList<int> licha = new LinkedList<int>();
            LinkedList<int> suda = new LinkedList<int>();
            RozdelPodleModula(ref spojak, licha, suda);
            Vypis2(ref licha);
            Vypis3(ref suda);

            // 14. RozdelMalaVelka
            LinkedList<int> mala = new LinkedList<int>();
            LinkedList<int> velka = new LinkedList<int>();
            RozdelMalaVelka(ref spojak, ref mala, ref velka);
            Vypis1(ref mala);
            Vypis2(ref velka);

            // 15. RozdelPrvniDruhy
            LinkedList<int> prvniDruhy = new LinkedList<int>();
            LinkedList<int> druhySeznam = new LinkedList<int>();
            RozdelPrvniDruhy(ref spojak, ref prvniDruhy, ref druhySeznam);
            Vypis3(ref prvniDruhy);
            Vypis1(ref druhySeznam);

            // 16. SpojeniUsp
            LinkedList<int> usporadany1 = new LinkedList<int>();
            LinkedList<int> usporadany2 = new LinkedList<int>();
            Naplneni(ref usporadany1, 5, 50);
            Naplneni(ref usporadany2, 5, 50);
            Vypis2(ref usporadany1);
            Vypis3(ref usporadany2);

            LinkedList<int> usporadanySpojeny = new LinkedList<int>();
                SpojeniUsp(ref usporadany1, ref usporadany2, ref usporadanySpojeny);
            
            Vypis1(ref usporadanySpojeny);

            // 17. VlozeniUsp
            LinkedList<int> usporadanySeznam = new LinkedList<int>();
            VlozeniUsp(ref usporadanySeznam, 20);
            VlozeniUsp(ref usporadanySeznam, 10);
            VlozeniUsp(ref usporadanySeznam, 30);
            Vypis2(ref usporadanySeznam);
        }
    }
}
