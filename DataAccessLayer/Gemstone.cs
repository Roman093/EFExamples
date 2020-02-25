﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Gemstone
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int GemstoneTypeId { get; set; }
        public virtual GemstoneType GemstoneType { get; set; }
    }
}
