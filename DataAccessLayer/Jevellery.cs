using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Jevellery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price {get; set;}
        public int ManufactoryId { get; set; }
        public Manufactory Manufactory { get; set; }
        public int JavelleryTypeId { get; set; }


        public virtual ICollection<Gemstone> Gemstones { get; set; }
    }
}
