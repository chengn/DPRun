using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.FactoryMethod
{
    public class Factory2:Factory
    {
        public Product CreateProduct()
        {
            return new Product2();
        }
    }
}
