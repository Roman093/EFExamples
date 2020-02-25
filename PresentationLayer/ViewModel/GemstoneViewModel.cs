using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
   public class GemstoneViewModel
    {
        public string Color { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public GemstoneTypeEnum Type {get; set;}
    }
}
