using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.AbstractFactory
{
    public class Factory1:Factory
    {
        public ProductA CreateProductA()
        {
            return new ProductA1();
        }

        public ProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
