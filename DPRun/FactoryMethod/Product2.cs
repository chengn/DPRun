using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.FactoryMethod
{
    public class Product2:Product
    {
        public string Method()
        {
            return "product2 say:hello world!";
        }
    }
}
