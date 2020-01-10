using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrzysztofJopekLab6ZadanieDomowe.Models
{
    public class BallerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string CurrentClub { get; set; }
        public string Position { get; set; }
        public string Photo { get; set; }

        public BallerViewModel( string firstName, string lastName, string birthDate, string currentClub, string position, string photo)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            CurrentClub = currentClub;
            Position = position;
            Photo = photo;
        }
    }
}
