﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wLightBoxLibrary
{
    public class Rgbw
    {
        public int ColorMode { get; set; }
        public int EffectId { get; set; }
        public String? DesiredColor { get; set; }
        public String? CurrentColor { get; set; }
        public String? LastOnColor { get; set; }
    }
}
