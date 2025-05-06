using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seznam_obrazce
{
    /// <summary>
    /// objekt čtverec dědí od obrazce
    /// </summary>
    class Ctverec : Bod
    {
        /// <summary>
        /// strana čtverce
        /// </summary>
        float stranaA;
        /// <summary>
        /// strana kladné číslo jinak se nastaví nula
        /// </summary>
        public float StranaA
        {
            get { return stranaA; }
            private set
            {
                if (value > 0)
                {
                    stranaA = value;
                }
                else stranaA = 0;
            }
        }
        /// <summary>
        /// konstruktor dědí od obrazce jeho konstruktor se dvěma parametry
        /// </summary>
        /// <param name="a">strana čtverce</param>
        /// <param name="x">x-ová souřadnice středu </param>
        /// <param name="y">y-ová souřadnice středu</param>
        public Ctverec(float a, float x, float y) : base(x, y)
        {
            StranaA = a;
        }
        /// <summary>
        /// virtuální metoda výpočet obsahu čtverce
        /// </summary>
        /// <returns>vrací obsah čtverce</returns>
        virtual public float Obsah()
        {
            return StranaA * StranaA;
        }
        /// <summary>
        /// virtuální metoda výpočet  čtverce
        /// </summary>
        /// <returns>vrací obvod čtverce</returns>
        virtual public float Obvod()
        {
            return 4 * StranaA;
        }
        /// <summary>
        /// přepisuje virtuální metodu info obrazce
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            return base.Info() + "\n a= " + StranaA.ToString() + "\n S = " +
            Obsah().ToString("F2") + "\n O = " + Obvod().ToString("F2");
        }

    }
}



