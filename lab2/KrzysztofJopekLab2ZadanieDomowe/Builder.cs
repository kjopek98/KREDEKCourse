using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    class Builder : Worker
    {
        /// <summary>
        /// Konstruktor klasy Tram
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Builder(int hp, string name)
        {
            cost = 200;
            healthPoints = hp;
            workerName = name;

        }
        public override string StartWork()
        {
            return "Robotnik " + workerName + " zaczął pracę";
        }

        public override string StopWork()
        {
            return "Robotnik " + workerName + " sprzedany";
        }
    }
}
