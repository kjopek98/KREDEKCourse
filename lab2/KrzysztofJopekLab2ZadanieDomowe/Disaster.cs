using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    abstract public class Disaster
    {
        //zmienne - "statystyki" katastrofy.
        protected string name;
        protected int damagePoints;

        /// <summary>
        /// Metoda pobierająca ilość obrażeń
        /// </summary>
        /// <returns></returns>
        public virtual int GetDamagePoints()
        {
            return damagePoints;
        }
        /// <summary>
        /// Metoda pobierająca nazwę zdarzenia
        /// </summary>
        /// <returns></returns>
        public virtual string GetName()
        {
            return name;
        }
        /// <summary>
        /// Metoda ustawiająca ilość obrażeń
        /// </summary>
        /// <param name="n"></param>
        public virtual void SetDamagePoints(int n)
        {
            damagePoints = n;
        }


        // Metody abstrakcyjne do zdefiniowania w klasach dzieciach!
        abstract public string StartDisaster();

    }
}
