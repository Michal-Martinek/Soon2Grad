using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oops
{
    class Pole
    {
        protected int rust;//klíčové slovo protected označuje úroveň přístupu, která umožňuje přístup k metodám nebo vlastnostem pouze:
                           //Uvnitř samotné třídy, kde je člen deklarován.
                           //V odvozených třídách (dědících ze třídy, kde je člen deklarován).
        bool urodna_cernozem;
        public Pole(bool urodna)
        {
            Urodna_cernozem = urodna;
        }

        public bool Urodna_cernozem
        {
            get { return urodna_cernozem; }
            set
            {
                rust = 0;
                urodna_cernozem = value;
            }
        }

        public virtual void Zalit()
        {
            if (Urodna_cernozem)
            {
                rust = rust + 3;
            }
            else
            {
                rust++;
            }
        }
        public virtual int Sklidit()
        {
            if (rust >= 6)
            {
                rust = 0;
                return 1; //sklizení úspěšné
            }
            else { return 0; } // ješte není zralé
        }

        virtual public string Info()
        {
            return "Pole úrodná černozem= " + Urodna_cernozem + " růst= " + rust.ToString();
        }
    }

    class Obilne_Pole : Pole
    {
        bool oseto;
        public void Osit() { oseto = true; rust = 0; }
        public Obilne_Pole(bool urodna_cernozem) : base(urodna_cernozem)
        {
            oseto = false;
        }
        public override int Sklidit()
        {
            if (rust >= 4)
            {
                rust = 0;
                if (oseto)
                {
                    oseto = false;
                    return 1; //sklizení úspěšné
                }
                else
                {
                    return 2; // byl sklizen pouze přerostlý plevel
                }
            }
            else { return 0; } // ješte není zralé
        }
        override public void Zalit()
        {
            if (Urodna_cernozem)
            {
                rust = rust + 2;
            }
            else
            {
                rust++;
            }
        }
        public override string Info()
        {
            return "Obilné " + base.Info() + " oseto " + oseto;
        }

    }




    class Program
    {

        static void Main(string[] args)
        {
            Random nahoda = new Random();
            long penize = 0;
            long penize_minule = 0;
            //založíme farmu
            Pole[] farma = new Pole[4];
            farma[0] = new Pole(false);
            farma[1] = new Pole(true);
            farma[2] = new Obilne_Pole(false);
            farma[farma.Length - 1] = new Obilne_Pole(true);

            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                if (penize > 4)
                {
                    Obilne_Pole oseti = (Obilne_Pole)farma[nahoda.Next(2, 4)];
                    penize -= 5;
                    oseti.Osit();
                }

                for (int i = 0; i < farma.Length; i++)
                {

                    for (int j = 0; j < nahoda.Next(4); j++)
                    {
                        farma[i].Zalit();
                    }
                    switch (farma[i].Sklidit())
                    {
                        case 0:
                            Console.WriteLine(farma[i].Info() + ": Ještě není zralé.");
                            break;
                        case 1:
                            Console.WriteLine(farma[i].Info() + ": Sklizení úspěšné.");
                            penize = penize + 10;
                            break;
                        case 2:
                            Console.WriteLine(farma[i].Info() + ": Sklizen pouze přerostlý plevel.");
                            penize = penize + 2;
                            break;

                        default:
                            Console.WriteLine(":-( Tohle se nemělo stát.");
                            break;
                    }


                }
                Console.WriteLine("Zisk: " + (penize - penize_minule + " K"));
                Console.WriteLine("Stav účtu: " + penize + " K");
                penize_minule = penize;
                Console.ReadKey();
            }
        }
    }
}
