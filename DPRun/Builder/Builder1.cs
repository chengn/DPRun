using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Builder
{
    public class Builder1:Builder
    {
        private Product product = new Product1();
        public void BuildPartA()
        {
            //产品零件A的构建操作
            //零件A也可以是一个对象，这里就是零件对象的一些操作
        }

        public void BuildPartB()
        {
            //产品零件B的构建操作
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
