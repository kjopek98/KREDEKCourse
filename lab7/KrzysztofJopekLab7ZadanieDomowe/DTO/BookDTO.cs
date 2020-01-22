using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrzysztofJopekLab7ZadanieDomowe.DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
