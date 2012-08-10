using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.FactoryMethod;

namespace DP.Test
{
    public class FactoryMethodTest
    {
        /// <summary>
        /// 测试FactoryMethod
        /// </summary>
        public static void Test()
        {
            Factory f1 = new Factory1();
            Factory f2 = new Factory2();

            Product p1 = f1.CreateProduct();
            Product p2 = f2.CreateProduct();

            string p1Say = p1.Method();
            string p2Say = p2.Method();

            Console.WriteLine(p1Say);
            Console.WriteLine(p2Say);
        }
    }
}
