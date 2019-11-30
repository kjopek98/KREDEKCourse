using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    class Flood : Disaster
    {
        /// <summary>
        /// Konstruktor klasy Flood
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Flood( int dp)
        {
            damagePoints = dp;
        }
        /// <summary>
        /// Metoda informująca o powodzi.
        /// </summary>
        /// <returns></returns>
        public override string StartDisaster()
        {
            return "Powódź zalała osadę! Tracisz po  części jednostek każdego surowca!";
        }

    }
}
