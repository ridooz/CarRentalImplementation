using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaradayCarRental.Entities
{
    class Airport : PickUpStation
    {
        public string IATA { get; set; }

        public Airport()
        {

        }
    }
}
