using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.AbstractFactory
{
    public class Factory2:Factory
    {
        public ProductA CreateProductA()
        {
            return new ProductA2();
        }

        public ProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
