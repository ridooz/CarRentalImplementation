using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaradayCarRental.Entities
{
    class RentalCar
    {
        public Type Type { get; set; }
        public string LicensePlate { get; set; }
        public bool Available { get; set; }
        public PickUpStation CurrentLocation { get; set; }

        public RentalCar()
        {

        }
    }
}
