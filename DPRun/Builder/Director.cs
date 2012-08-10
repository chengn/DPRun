using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Builder
{
    public class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            //builder = new Builder1();这里不应该有吧？
            //装配零件A
            builder.BuildPartA();
            //装配零件B
            builder.BuildPartB();
            //生产产品
            //builder.GetProduct();
        }
    }
}
