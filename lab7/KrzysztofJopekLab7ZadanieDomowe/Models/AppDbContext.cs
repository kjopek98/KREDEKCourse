using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrzysztofJopekLab7ZadanieDomowe.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //LoadDefaultBooks();
        }

       /* public List<Book> GetBooks()
        {

        }*/

        private void LoadDefaultBooks()
        {
            Books.Add(new Book { BookId = 1, Title = "Dwie wieże", Author = "Tolkien", Year = 1998, Type = "Fantasy", Description = "Druga część LOTR" });
            Books.Add(new Book { BookId = 1, Title = "Powrót króla", Author = "Tolkien", Year = 2001, Type = "Fantasy", Description = "Trzecia część LOTR" });
        }
    }
}
