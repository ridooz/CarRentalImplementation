using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaradayCarRental.Entities
{
    public class Type
    {
        public char TypeName { get; set; }
        public decimal Price { get; set; }
        public int SeatAmount { get; set; }

        public Type()
        {

        }
    }
}
