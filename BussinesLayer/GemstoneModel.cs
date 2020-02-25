using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class GemstoneModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual GemstoneTypeEnum Type { get; set; }
    }
}
