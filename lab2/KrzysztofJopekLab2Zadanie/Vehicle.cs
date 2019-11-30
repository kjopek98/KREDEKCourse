using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2Zadanie
{
    abstract public class Vehicle
    {
        protected int vehicleNumber, yearOfProduction;
        protected string name;
        /// <summary>
        /// Metoda pobierająca numer pojazdu
        /// </summary>
        /// <returns></returns>
        public virtual int GetVehicleNumber()
        {
            return vehicleNumber;
        }
        /// <summary>
        /// Metoda pobierająca rok produkcji
        /// </summary>
        /// <returns></returns>
        public virtual int GetYearOfProduction()
        {
            return yearOfProduction;
        }
        /// <summary>
        /// Metoda pobierająca nazwę pojazdu
        /// </summary>
        /// <returns></returns>
        public virtual string GetName()
        {
            return name;
        }
        /// <summary>
        /// Metoda ustawiająca nr pojazdu
        /// </summary>
        /// <param name="n"></param>
        public virtual void SetVehicleNumber(int n)
        {
            vehicleNumber = n;
        }
        // Metody abstrakcyjne do zdefiniowania w klasach dzieciach!
        abstract public string StartVehicle();
        abstract public string StopVehicle();
    }
}
