using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.AbstractFactory
{
    public interface Factory
    {
        ProductA CreateProductA();
        ProductB CreateProductB();
    }
}
