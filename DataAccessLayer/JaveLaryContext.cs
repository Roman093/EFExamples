using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class JaveLaryContext : DbContext
    {

        public JaveLaryContext() : base(@"Data Source=.\SQLEXPRESS; Initial Catalog=Jevelary; Integrated Security=true ")
        {
        }
        public DbSet<Jevellery> Jevelleries { get; set; }
        public DbSet<Gemstone> Gemstones { get; set; }
        public DbSet<Manufactory> Manufactories { get; set; }
        public DbSet<GemstoneType> GemstoneTypes { get; set; }
    }
}

