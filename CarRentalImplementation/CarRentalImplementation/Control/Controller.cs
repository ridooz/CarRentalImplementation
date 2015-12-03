using FaradayCarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaradayCarRental.Data;

namespace FaradayCarRental.Control
{
    class Controller
    {
        private DummyBackend dummyBackend;

        public Controller()
        {
            dummyBackend = new DummyBackend();
        }

        public List<RentalCar> ShowAvailableCars(string city)
        {
            return dummyBackend.ShowAvailableCars(city);
        }
    }
}
