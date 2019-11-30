using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    class Miner : Worker
    {
        /// <summary>
        /// Konstruktor klasy Tram
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Miner(int hp,  string name)
        {
            cost = 100;
            healthPoints = hp;
            workerName = name;

        }

        public override string StartWork()
        {
            return "Górnik " + workerName + " zaczął pracę.";
        }

        public override string StopWork()
        {
            return "Górnik " + workerName + " zginął";
        }
    }
}
