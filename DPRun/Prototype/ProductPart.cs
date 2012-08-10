using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Prototype
{
    /// <summary>
    /// 产品类的实现，实现了克隆方法的接口，可以克隆自身
    /// </summary>
    public class ProductPart:IProduct
    {
        //定义类的属性
        private string part1;
        private string part2;

        public ProductPart()
        { }

        /// <summary>
        /// 可以创建另一个自己的构造方法
        /// </summary>
        /// <param name="p"></param>
        public ProductPart(string part1,string part2)
        {
            this.Part1 = part1;
            this.Part2 = part1;
        }
        /// <summary>
        /// 克隆自己的方法，返回自己的另一个副本
        /// </summary>
        /// <returns></returns>
        public IProduct Clone()
        {
            return new ProductPart(this.part1,this.part2);
        }

        public string Part1
        {
            get { return this.part1; }
            set { this.part1 = value; }
        }

        public string Part2
        {
            get { return this.part2; }
            set { this.part2 = value; }
        }

    }
}
