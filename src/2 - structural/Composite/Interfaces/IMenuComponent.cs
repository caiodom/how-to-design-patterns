﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Interfaces
{
    public interface IMenuComponent
    {
        string GetName();
        decimal GetPrice();
        void Display();
    }
}
