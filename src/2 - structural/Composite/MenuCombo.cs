using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    public class MenuCombo : IMenuComponent
    {
        private readonly string _name;

        private readonly List<IMenuComponent> _components=new List<IMenuComponent>();

        public MenuCombo(string name)
        {
            _name = name;          
        }

        public void AddComponent(IMenuComponent component)
        {
            _components.Add(component);
        }

        public void Display()
        {
           Console.WriteLine($"Combo {_name}");

            foreach (var component in _components)
                component.Display();

            Console.WriteLine($"Total do combo {_name}: ${GetPrice()}");
        }

        public string GetName()
                          => _name;


        public decimal GetPrice()
                   => _components.Sum(c=>c.GetPrice());
    }
}
