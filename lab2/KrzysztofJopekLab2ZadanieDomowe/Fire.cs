using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    public class Fire : Disaster
    {
        /// <summary>
        /// Konstruktor klasy Fire
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Fire( int dp)
        {
            damagePoints = dp;
        }

        public void Damage( Worker worker)
        {
            
            worker.healthPoints -= damagePoints;
        }
        /// <summary>
        /// Metoda informująca o pożarze.
        /// </summary>
        /// <returns></returns>
        public override string StartDisaster()
        {
            return "Pożar w lesie! Tracisz część swoich jednostek drewna!";
        }
    }
}
