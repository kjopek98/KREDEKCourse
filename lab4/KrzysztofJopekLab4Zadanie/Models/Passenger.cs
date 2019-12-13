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
    class Passenger
    {

        [Key]
        public int Id { get; set; }
        [DisplayName("Imię")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Nazwisko")]

        public string Surname { get; set; }
        [DisplayName("E-mail")]

        public string Email { get; set; }
        [DisplayName("Numer telefonu")]
        [Required]
        public string Phone { get; set; }

        public int AddressId { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        public virtual List<Ticket> Tickets { get; set; }
    }
}
