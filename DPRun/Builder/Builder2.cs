using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Builder
{
    public class Builder2:Builder
    {
        private Product product = new Product2();
        public void BuildPartA()
        {
            //产品零件A的构建操作
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
