using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab4Zadanie.Models
{
    class Ticket
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Numer Siedzenia")]
        [Required]
        public string Place_number { get; set; }

        public int LuggageId { get; set; }

        [ForeignKey("LuggageId")]
        public virtual Luggage Luggage { get; set; }
        public int PassengerId { get; set; }

        [ForeignKey("PassengerId")]
        public virtual Passenger Passenger { get; set; }
        public int FlightId { get; set; }

        [ForeignKey("FlightId")]
        public virtual Flight Flight { get; set; }
    }
}
