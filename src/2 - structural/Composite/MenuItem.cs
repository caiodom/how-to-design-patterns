using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //leaf
    public class MenuItem:IMenuComponent
    {
        private string _name;
        private decimal _price;

        public MenuItem(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public void Display()
        {
            Console.WriteLine($"{_name}: {_price}");
        }

        public string GetName()=>_name;


        public decimal GetPrice() => _price;
    }
}
