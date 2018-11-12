using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class ResponseModal
    {
        public string Status { get; set; }
        public object ResponseData { get; set; }
        public string Error { get; set; }
    }
}
