using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekEgzaminZadanieA._5.Models
{
    class Programmers
    {
        [Key]
        public int idProgrammer { get; set; }
        [DisplayName("Imię")]
        [Required]
        public string name { get; set; }
        [DisplayName("Nazwisko")]
        public float surname { get; set; }
        [DisplayName("Poziom")]
        public float level { get; set; }
        public virtual List<Projects> Projects { get; set; } //programista  może posiadać wiele projektów
    }
}
