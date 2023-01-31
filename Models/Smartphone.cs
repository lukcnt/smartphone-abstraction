using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone_abstraction.Models
{
    public class Smartphone
    {
        public string Number { get; set; }
        private string Model { get; set; }
        private string Imei { get; set; }
        private string Memory { get; set; }
    }
}