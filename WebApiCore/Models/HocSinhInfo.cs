﻿using System;
using System.Collections.Generic;

namespace WebApiCore.Models
{
    public partial class HocSinhInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
    }
}
