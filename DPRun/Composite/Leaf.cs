using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.CompositeP
{
    /// <summary>
    /// 叶子结点，只实现结构中定义的操作型方法，结构维护型方法不用实现
    /// </summary>
    public class Leaf : Component
    {
        private string name;
        public Leaf(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 叶子的操作
        /// </summary>
        public void Method()
        {
            Console.WriteLine(this.name); 
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
