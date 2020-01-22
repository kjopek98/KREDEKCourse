using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrzysztofJopekLab7ZadanieDomowe.Models
{
    public class ApplicationDbContext : DbContext
    {
        //Dodanie tabel do bazy danych
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
