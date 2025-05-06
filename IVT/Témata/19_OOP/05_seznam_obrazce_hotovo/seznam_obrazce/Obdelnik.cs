using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seznam_obrazce
{

    /// <summary>
    /// Obdélník dědí od čtverce navíc strana b
    /// </summary>
    class Obdelnik : Ctverec
    {
        float stranaB;
        public float StranaB
        {
            get { return stranaB; }
            private set
            {
                if (value > 0)
                {
                    stranaB = value;
                }
                else stranaB = 0;
            }
        }
        /// <summary>
        /// konstruktor obdélníka dědí konstrukror čtverce navíc inicializuje stranu b
        /// </summary>
        /// <param name="a">strana a</param>
        /// <param name="b">strana b</param>
        /// <param name="x">x-ová souřadnice středu</param>
        /// <param name="y">y-ová souřadnice středu</param>
        public Obdelnik(float a, float b, float x, float y) : base(a, x, y)
        { StranaB = b; }
        public override float Obsah()
        {
            return StranaA * StranaB;
        }
        public override float Obvod()
        {
            return 2 * (StranaA + StranaB);
        }
        public override string Info()
        {
            /*return "Obdélník:\n x = " + X.ToString("F2") + "\n y = " + Y.ToString("F2") + "\n a= " + StranaA.ToString() + "\n b= " + StranaB.ToString() + "\n S = " +
            Obsah().ToString("F2") + "\n O = " + Obvod().ToString("F2");*/
            return base.Info()+ "\n b= " + StranaB.ToString();

        }
    }
}
