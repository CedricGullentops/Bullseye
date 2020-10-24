﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FysicsLeague.Models
{
    public class Prefix
    {
        [Key]
        public string Name { get; set; }
        public double Value { get; set; }
    }
}
