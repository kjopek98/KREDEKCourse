using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    class Dealer : Worker
    {
        /// <summary>
        /// Konstruktor klasy Tram
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Dealer(int hp ,string name)
        {
            cost = 400;
            healthPoints = hp;
            workerName = name;

        }
        public override string StartWork()
        {
            return "Kupiec " + workerName + " zaczął pracę";
        }

        public override string StopWork()
        {
            return "Kupiec " + workerName + " sprzedany";
        }
    }
}
