using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    abstract public class Worker
    {
        //zmienne - "statystyki" robotnika.
        protected int healthPoints, cost;
        protected string workerName;

        /// <summary>
        /// Metoda pobierająca ilość punktów życia
        /// </summary>
        /// <returns></returns>
        public virtual int GetHealthPoints()
        {
            return healthPoints; ;
        }


        /// <summary>
        /// Metoda pobierająca ilość punktów życia
        /// </summary>
        /// <returns></returns>
        public virtual int GetCost()
        {
            return cost; ;
        }

        /// <summary>
        /// Metoda pobierająca nazwę robotnika
        /// </summary>
        /// <returns></returns>
        public virtual string GetWorkerName()
        {
            return workerName;
        }
        /// <summary>
        /// Metoda ustawiająca ilość punktów życia
        /// </summary>
        /// <param name="n"></param>
        public virtual void SetHealthPoints(int n)
        {
            healthPoints = n;
        }
     
        // Metody abstrakcyjne do zdefiniowania w klasach dzieciach!
        abstract public string StartWork();
        abstract public string StopWork();



    }
}
