using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaradayCarRental.Entities
{
    class Hotel : PickUpStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int StarRating { get; set; }

        public Hotel()
        {

        }
    }
}
