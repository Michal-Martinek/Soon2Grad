using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;







/// naimplementováno:
      ///      l.Count(), l.Sum(), l.Min(), l.Max(), l.Average()
/// konstruktory: list(2, 4) -> [2, 2 ,2, 2] (tedy 4-krát dvojka)
/// list(1, 2, 3, 4 ,5) -> [1, 2, 3, 4, 5]


//////
///








namespace lin_seznam_start {
    //dopište chybějící těla metod
    //přidejte vlastnost Count, počet prvků seznamu



    /// <summary>
    /// třída reprezentující jeden uzel spojového seznamu
    /// </summary>    
    public class Node {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int item) // konstruktor jednoho uzle
        {
            Value = item;
            Next = null;
        }
    }
    /// <summary>
    /// vlastní lineární spojový seznam jednosměrný, neuspořádaný, s ukazatelem na první a poslední prvek
    /// </summary>
    public class MyLinkedList {
        public Node First { get; private set; }    //první prvek seznamu
        public Node Last { get; private set; }    //poslední prvek seznamu
        /// <summary>
        /// Konstruktor spojového seznamu, vytvoří prázdný seznam
        /// </summary>
        /// 
        public void initEmptyList() {
            First = null;
            Last = null;
        }
        /// <summary>
        /// Konstruktor spojového seznamu, vytvoří seznam s @count opakováním hodnoty @val
        /// </summary>
        /// 
        public MyLinkedList(int val, int count) {
            initEmptyList();
            for (int i = 0; i < count; ++i) {
                AddFirst(val);
            }
        }
        /// <summary>
        /// Konstruktor spojového seznamu, vytvoří seznam z libovolného seznamu čísel v params
        /// </summary>
        /// 
        public MyLinkedList(params int[] arr) {
            initEmptyList();
            for (int i = arr.Length - 1; i >= 0; --i) {
                AddFirst(arr[i]);
            }
        }

        /// <summary>
        /// vloží prvek na začátek seznamu
        /// </summary>
        /// <param name="item">položka kterou vkládám</param>
        public void AddFirst(int item) {
            Node node = new Node(item);
            if (First == null) //seznam je prázdný
            {
                First = node;
                Last = node;
            } else {
                node.Next = First;
                First = node;
            }

        }


        /// <summary>
        /// odstraní první prvek seznamu
        /// </summary>
        public void RemoveFirst() {
            if (First != null) First = First.Next;
            if (First == null) Last = null;
        }
        /// <summary>
        /// Vloží prvek na konec seznamu 
        /// </summary>
        /// <param name="hodnota">číslo, které vkládám</param>
        public void AddLast(int hodnota) {
            if (Last == null) { AddFirst(hodnota); return; }
            Last.Next = new Node(hodnota);
            Last = Last.Next;
        }

        /// <summary>
        /// odstraní poslední prvek seznamu
        /// </summary>
        public void RemoveLast() {
            Node itr = First;
            if (itr == null || First == Last) {
                RemoveFirst();
                return;
            }
            while (itr.Next != Last) {
                itr = itr.Next;
            }
            itr.Next = null;
            Last = itr;

        }
        /// <summary>
        /// vypíše prvky seznamu
        /// </summary>
        /// <returns>prvky seznamu</returns>
        public string Vypis() {
            Node curr;
            curr = First;
            string s = "";
            while (curr != null) {
                if (s.Length != 0) s += ", ";
                s += curr.Value.ToString();
                curr = curr.Next;
            }
            return "[" + s + "]";
        }
        /// <summary>
        /// nalezne prvek v seznamu, pokud je v seznamu odstraní ho
        /// </summary>
        /// <param name="item">hledaná položka seznamu</param>
        public void Remove(int item) {
            Node itr = First;
            while (itr != null) {
                if (itr.Value == item) RemoveFirst();
                if (itr.Next != null && itr.Next.Value == item) {
                    itr.Next = itr.Next.Next;
                    if (itr.Next == null) Last = itr;
                } else itr = itr.Next;
            }
        }

        public int Count() {
            int count = 0;
            for (Node itr = First; itr != null;) {
                itr = itr.Next;
                count++;
            }
            return count;
        }
        /// max, min, průměr jako metody
        public int Min() {
            int min = int.MaxValue;
            for (Node itr = First; itr != null; itr = itr.Next) {
                min = itr.Value < min ? itr.Value : min;
            }
            return min;
        }
        public int Max() {
            int max = int.MinValue;
            for (Node itr = First; itr != null; itr = itr.Next) {
                max = itr.Value > max ? itr.Value : max;
            }
            return max;
        }
        public int Sum() {
            int sum = 0;
            for (Node itr = First; itr != null; itr = itr.Next) {
                sum += itr.Value;
            }
            return sum;
        }
        public float Average() {
            return (float)Sum() / (float)Count();
        }
    }


    internal class Program
    {
        static void debugList(MyLinkedList l) {
            Console.WriteLine("count: {0}, sum: {1}, min {2}, max {3}, average {4}", l.Count(), l.Sum(), l.Min(), l.Max(), l.Average());

        }
        static void Main(string[] args)
        {
            MyLinkedList l = new MyLinkedList();
            l.AddLast(1);
            l.AddFirst(2);
            l.AddLast(5);
            Console.WriteLine(l.Vypis());
            debugList(l);


            l.RemoveFirst();
            Console.WriteLine(l.Vypis());
            l.AddLast(3);
            l.AddLast(4);
            Console.WriteLine(l.Vypis());
            l.Remove(5);
            Console.WriteLine(l.Vypis());
            l.RemoveLast();
            Console.WriteLine(l.Vypis());
            Console.WriteLine("Count: {0}", l.Count());
            l.RemoveLast();
            Console.WriteLine(l.Vypis());
            l.Remove(1);
            Console.WriteLine(l.Vypis());
            l.AddFirst(2);
            Console.WriteLine(l.Vypis());
            l.RemoveLast();
            Console.WriteLine(l.Vypis());
            Console.WriteLine("len: {0}", l.Count());

            // test konstruktorů
            MyLinkedList repeats = new MyLinkedList(4, 6);
            Console.WriteLine(repeats.Vypis());

            int[] arr = {1, 4, 9, 16, 25};
            MyLinkedList fromArr = new MyLinkedList(arr);
            Console.WriteLine(fromArr.Vypis());
            fromArr = new MyLinkedList(1, 1, 2, 3, 5, 8, 13);
            Console.WriteLine(fromArr.Vypis());
            debugList(fromArr);

            Console.ReadKey();
        }
    }
}
;