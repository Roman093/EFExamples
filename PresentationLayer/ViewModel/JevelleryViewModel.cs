using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
   public class JevelleryViewModel
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public IEnumerable<GemstoneViewModel> Gemstones { get; set; }
        public ManufactoryViewModel Manufactory { get; set; }
    }
}
