using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Zadejte číslo, které bude dělit číslo 1");
            //dělení nulou  => běhová chyba jen pro celočíselný typ
            //dělení nulou pro float double není chyba výsledek 
            try
            {
                int num = int.Parse(Console.ReadLine());
                //if (num==0) throw new DivideByZeroException("dělení nulou ");
                int result = 1 / num;
                Console.WriteLine("1 / {0} = {1}", num, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nastala chyba! "+ex.Message);
            }
            Console.ReadKey();
           
               
        }
        
    }
}
