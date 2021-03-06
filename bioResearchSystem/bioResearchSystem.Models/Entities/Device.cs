﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bioResearchSystem.Models.Entities
{
    public class Device:Entity
    {
        public string Alias { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int BoundRateDevice { get; set; }
        public string PortName { get; set; }
    }
}
