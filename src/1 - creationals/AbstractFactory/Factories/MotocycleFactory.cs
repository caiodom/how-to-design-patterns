using AbstractFactory.Interfaces;
using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class MotocycleFactory : IMotocycleFactory
    {
        public IVehicle CreateCruiser()
                                => new Cruiser();

        public IVehicle CreateSportBike()
                                => new Sportbike();

    }
}
