using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.AbstractFactory;

namespace DP.Test
{
    public class AbstractFactoryTest
    {
        public static void Test()
        {
            Factory f1 = new Factory1();
            Factory f2 = new Factory2();

            ProductA A1 = f1.CreateProductA();
            ProductA A2 = f2.CreateProductA();
            ProductB B1 = f1.CreateProductB();
            ProductB B2 = f2.CreateProductB();

            string strA1Say = A1.Method();
            string strA2Say = A2.Method();
            string strB1Say = B1.Method();
            string strB2Say = B2.Method();
        }
    }
}
