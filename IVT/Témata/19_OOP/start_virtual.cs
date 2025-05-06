using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @virtual
{
    class Program
    {
        public class Obrazec
        {
            int stredX; //protected není potřeba, potomci k této proměnné nepřistupují
            int stredY;
            public Obrazec(int x, int y)
            {
                stredX = x;
                stredY = y;
            }

            public double VzdalenostOdPocatku()
            {
                return Math.Sqrt(stredX * stredX + stredY * stredY);
            }

            public double VzdalenostOdObrazce(Obrazec k)
            {
                return Math.Sqrt((this.stredX - k.stredX) * (this.stredX - k.stredX) + (this.stredY - k.stredY) * (this.stredY - k.stredY));
            }

            public string Obsah() { return " má obsah "; }

        }
        public class Ctverec : Obrazec
        {
            int strana_a;
            public string Obsah()
            {
                return "Čtverec " + base.Obsah() + strana_a * strana_a;
            }
            public Ctverec(int a, int x, int y):base( x, y)
            {
                strana_a = a;
            }
        }
        
        static void Main(string[] args)
        {
            //Obdelnik obd = new Obdelnik(10, 20,0,0);
            Ctverec ctv = new Ctverec(5,1,1);
            Console.WriteLine(ctv.Obsah());
            //Kruh k = new Kruh(5,1,1);
            Obrazec obr = new Obrazec(10,10);
            Console.WriteLine(obr.Obsah());
            obr = ctv; //lze
            //ctv = obr; //nelze



            //Console.WriteLine("vzdalenost pocatek"+ k.VzdalenostOdPocatku());
            //Console.WriteLine("vzd obrazcec "+k.VzdalenostOdObrazce(ctv));

            List<Obrazec> seznam = new List<Obrazec>();
            //seznam.Add(obd);
            seznam.Add(ctv);
            //seznam.Add(k);
            seznam.Add(obr);

            foreach (Obrazec x in seznam)
            {
                Console.WriteLine(x.Obsah());
            }
            
           
        Console.ReadKey();
        }
        
        
    }
}
