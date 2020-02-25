using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
   public class JavelaryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int ManufactoryId { get; set; }
        public ManufactoryModel ManufactoryModel { get; set; }
        public int JavelleryTypeId { get; set; }


        public virtual ICollection<GemstoneModel> Gemstones { get; set; }
    }
}
