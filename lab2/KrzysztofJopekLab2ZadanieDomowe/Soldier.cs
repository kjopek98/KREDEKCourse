﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    class Soldier : Worker
    {
        /// <summary>
        /// Konstruktor klasy Tram
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Soldier(int hp,  string name)
        {
            cost = 300;
            healthPoints = hp;
            workerName = name;

        }

        public override string StartWork()
        {
            return "Żołnierz " + workerName + " broni osady.";
        }

        public override string StopWork()
        {
            return "Żołnierz " + workerName + " sprzedany";
        }
    }
}
