using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seznam_obrazce
{
    class Bod
    {
        /// <summary>
        /// x-ová souřadnice středu objektu
        /// </summary>
        public float X { get; private set; }
        /// <summary>
        /// y-ová souřadnice středu objektu
        /// </summary>
        public float Y { get; private set; }

        /// <summary>
        /// parametrický konstruktor
        /// </summary>
        /// <param name="x">x-ová souřadnice středu objektu</param>
        /// <param name="y">y-ová souřadnice středu objektu</param>
        public Bod(float x, float y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// virtuální metoda pro výpis informací o objektu
        /// </summary>
        /// <returns>vlastnosti objektu</returns>
        virtual public string Info()
        {
            return "souřadnice bodu:\n x = " + X.ToString("F2") + "\n y = " + Y.ToString("F2");
        }
    }
}

