using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab4Zadanie.Models
{
    class FlightStoreContext : DbContext
    {
        public FlightStoreContext() : base("AppContext")
        {

        }

        public virtual DbSet<Ticket> Tickets  { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }

        public virtual DbSet<Passenger> Passengers { get; set; }

        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Luggage> Luggage { get; set; }
    }


}
