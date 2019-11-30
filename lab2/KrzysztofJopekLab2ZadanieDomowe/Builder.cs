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
        /// Konstruktor klasy Builder
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
        /// <summary>
        /// Metoda informująca o zaczęciu pracy.
        /// </summary>
        /// <returns></returns>
        public override string StartWork()
        {
            return "Budowniczy " + workerName + " zaczął pracę";
        }
        /// <summary>
        /// Metoda informująca o sprzedaniu.
        /// </summary>
        /// <returns></returns>
        public override string StopWork()
        {
            return "Budowniczy" + workerName + " sprzedany";
        }
    }
}
