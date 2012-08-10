using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.Builder;

namespace DP.Test
{
    public class BuilderTest
    {
        public static void Test()
        {
            //定义一个生成器
            Builder.Builder builder = new Builder1();
            //定义一个指向该生成器的导向器
            Director director = new Director(builder);
            //由导向器来组装产品
            director.Construct();
            //生成器生成产品
            Product product = builder.GetProduct();

        }
    }
}
