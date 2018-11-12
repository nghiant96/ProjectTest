using System;
using System.Collections.Generic;

namespace WebApiCore.Models
{
    public partial class HocSinh
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Class { get; set; }
    }
}
