using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    class Invasion : Disaster
    {
        /// <summary>
        /// Konstruktor klasy Tram
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Invasion(int dp)
        {
            damagePoints = dp;
        }
        public override string StartDisaster()
        {
            return "Najazd barbarzyńców! Jeśli masz wystarczająco żołnierzy odeprzesz atak. " +
                "W innym wypadku barbarzyńcy łupią osadę i tracisz po części jednostek każdego surowca.";
        }
        public string StopDisaster()
        {
            return "Twoi żołnierze powstrzymali najazd barbarzyńców.";
        }
    }
}
