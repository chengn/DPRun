using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.SimpleFactory;

namespace DP.Test
{
    public class SimpleFactoryTest
    {
        public static void Test()
        {
            //生产产品1
            Product p1 = Factory.CreatProduct("product1");
            //生产产品2
            Product p2 = Factory.CreatProduct("product2");
        }
    }
}
