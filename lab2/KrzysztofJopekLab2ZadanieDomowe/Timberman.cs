using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    class Timberman : Worker
    {
        /// <summary>
        /// Konstruktor klasy Tram
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Timberman(int hp, string name)
        {
            cost = 100;
            healthPoints = hp;
            workerName = name;

        }
        /// <summary>
        /// Metoda informująca o zaczęciu pracy.
        /// </summary>
        /// <returns></returns>
        public override string StartWork()
        {
            return "Drwal " + workerName + " zaczął pracę.";
        }
        /// <summary>
        /// Metoda informująca o sprzedaniu.
        /// </summary>
        /// <returns></returns>
        public override string StopWork()
        {
            return "Drwal " + workerName + " sprzedany";
        }
    }
}
