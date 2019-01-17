﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class BattleEvents
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public DateTime Time { get; set; }
        public Battle Battle { get; set; }
    }
}
