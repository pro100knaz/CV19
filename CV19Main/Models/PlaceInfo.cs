﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19Main.Models
{
    internal class PlaceInfo
    {
        public string Name { get; set; }

        public virtual PersonalPoint Location { get; set; }

        public virtual IEnumerable<ConfirmedCount> Counts { get; set; }
    }
}
