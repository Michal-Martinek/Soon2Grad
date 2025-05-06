using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obousmerny_seznam_uvod {
    class Program {
        static void NahodneNaplneni(ref LinkedList<int> s, int pocet, int rozsah) {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 1; i <= pocet; i++) {
                s.Insert(rand.Next(0, rozsah));
            }
        }

        static void Vypis(ref LinkedList<int> s, string msg, bool endl=true) {
            Console.Write("{0}: {", msg);
            bool first = true;
            foreach (int i in s) {
                if (first) {
                    Console.Write("{0}", i);
                } else Console.Write(", {0}", i);
            }
            Console.Write("}");
            if (endl) Console.WriteLine();
        }

        // listové operace --------------------------------
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

        // operace uspořádaného seznamu --------------------------------------

        void sort(bool allowDups=true) {
            // insertion sort
            while
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
            NahodneNaplneni(ref spojak, 10, 100);
            Vypis(ref spojak, "Random init");


            
        }
    }
}
