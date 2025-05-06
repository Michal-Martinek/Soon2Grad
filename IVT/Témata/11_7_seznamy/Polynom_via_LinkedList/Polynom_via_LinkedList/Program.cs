using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Polynom_via_LinkedList {

    public class Polynomial {
        private LinkedList<double> members = new LinkedList<double>(); // from biggest to smallest, all powers must be present

        public Polynomial() {
            members.AddLast(-1.5);
            members.AddLast(-3);
            members.AddLast(1);
        }
        private void addZeroMembers(int count) {
            for (int i = 0; i < count; ++i) {
                members.AddFirst(0);
            }
        }
        public Polynomial(List<double> coeff, List<int> powers) {
            Debug.Assert(coeff != null && powers != null);
            Debug.Assert(coeff.Count() != 0 && coeff.Count() == powers.Count());
            int expectedPower = 0;
            for (int i = powers.Count()-1; i >= 0; --i) {
                int power = powers[i];
                if (power > expectedPower) addZeroMembers(power - expectedPower);
                members.AddFirst(coeff[i]);
                expectedPower = power + 1;
            }
        }


        public string toString(string afterCoeff="", string powerStr="^") {
            StringBuilder sb = new StringBuilder();
            LinkedListNode<double> node = members.First;
            for (int i = 0; i < members.Count; ++i) {
                Debug.Assert(node != null);
                if (node.Value != 0) {
                    int power = members.Count() - i - 1;

                    double coeffAbs = Math.Abs(node.Value);
                    sb.Append(node.Value < 0.0 ? " - " : i != 0 ? " + " : ""); // napíšeme znaménko, pokud je první člen, tak '+' vynecháme
                    if (coeffAbs != 1.0 || power == 0) sb.Append(coeffAbs.ToString() + afterCoeff); // napíšeme koeficient pokud není zbytečný

                    if (power != 0) sb.Append('x');
                    if (power > 1) sb.Append(powerStr + power.ToString());
                }
                node = node.Next;
            }
            return sb.ToString();
        }

        // public Polynomial operator+=(ref Polynomial other) {
            // implement
        // }
    }

    class Program {
        static Polynomial parseInput(string line) {
            line = line.Replace('.', ',');
            List<double> coeff = new List<double>();
            List<int> powers = new List<int>();
            string[] parts = line.Split(' ');
            for (int i = 0; i < parts.Count(); i += 2) {
                double c = double.Parse(parts[i]);
                coeff.Add(c);

                int power = int.Parse(parts[i + 1]);
                powers.Add(power);
            }
            return new Polynomial(coeff, powers);
        }
        public static void Main(string[] args) {
            string cin;
            //cin = Console.ReadLine();
            cin = "-1 6 7 2 -1.5 0";
            Polynomial p = parseInput(cin);
            string s = p.toString();
            Console.WriteLine(s);
        }
    }
}
;