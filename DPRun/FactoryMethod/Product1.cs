using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.FactoryMethod
{
    public class Product1:Product
    {
        public string Method()
        {
            return "product1 say:hello world!";
        }
    }
}
