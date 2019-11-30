using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    class Fire : Disaster
    {
        /// <summary>
        /// Konstruktor klasy Tram
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Fire( int dp)
        {
            damagePoints = dp;
        }

        public override string StartDisaster()
        {
            return "Pożar w lesie! Tracisz część swoich jednostek drewna!";
        }
    }
}
