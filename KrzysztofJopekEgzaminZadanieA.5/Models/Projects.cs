using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekEgzaminZadanieA._5.Models
{
    class Projects
    {
        [Key]
        public int idProject { get; set; }
        [DisplayName("Nazwa")]
        public float name { get; set; }
        [ForeignKey("CountryId")]
        public virtual Programmers Programmer { get; set; } // klucz obcy
        
    }
}
