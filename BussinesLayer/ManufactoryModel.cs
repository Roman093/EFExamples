using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
   public class ManufactoryModel
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public long LicenseNumber { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
