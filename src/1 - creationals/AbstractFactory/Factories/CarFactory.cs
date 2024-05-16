using AbstractFactory.Interfaces;
using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class CarFactory : ICarFactory
    {
        public IVehicle CreateSedan()
                    => new Sedan();


        public IVehicle CreateSUV()
                    => new Suv();

    }
}
