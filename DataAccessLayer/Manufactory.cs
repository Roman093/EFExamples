using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Manufactory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public long LicenseNumber { get; set; }
        public virtual ICollection<Gemstone> Gemstones { get; set; }
    }
}
