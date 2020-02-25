using System.Collections.Generic;

namespace BussinesLayer
{
    public class GemstoneType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GemstoneModel> Gemstones { get; set; }
    }
}