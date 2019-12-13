using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab4Zadanie.Models
{
    class Flight
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Miejsce wylotu")]
        [Required]
        public string Departure { get; set; }
        [DisplayName("Miejsce przylotu")]
        [Required]
        public string Arrival { get; set; }

        [DisplayName("Data lotu")]
        [Required]
        public DateTime FlightDate { get; set; }

        public virtual List<Ticket> Tickets { get; set; }
    }
}
