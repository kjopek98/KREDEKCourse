using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab4Zadanie.Models
{
    class Address
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Kraj")]
        [Required]
        public string Country { get; set; }
        [DisplayName("Województwo")]
        
        public string Province{ get; set; }
        [DisplayName("Powiat")]
        
        public string District { get; set; }
        [DisplayName("Miejscowość")]
        [Required]
        public string City { get; set; }
        [DisplayName("Ulica")]
        public string Street { get; set; }
        [DisplayName("Numer_domu")]
        [Required]
        public string House_number { get; set; }
        [DisplayName("Numer lokalu")]
        public string Local_number { get; set; }
        public virtual List<Passenger> Passengers { get; set; }

    }
}
