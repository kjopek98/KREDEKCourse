using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab4Zadanie.Models
{
    class Luggage
    { 
        [Key]
        public int Id { get; set; }
        [DisplayName("Pakiet")]
        [Required]
        public string Package { get; set; }

        public virtual List<Ticket> Tickets { get; set; }
    }
}
