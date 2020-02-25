﻿using System.Collections.Generic;

namespace DataAccessLayer
{
    public class GemstoneType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Gemstone> Gemstones { get; set; }
    }
}