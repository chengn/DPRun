using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.VisitorDP
{
    /// <summary>
    /// 访问器1，实现访问器接口，对元素结构的一类操作规则（算法）
    /// </summary>
    public class Visitor1:Visitor
    {
        /// <summary>
        /// Visitor1对元素Element1实现的一种具体操作（算法）
        /// </summary>
        /// <param name="e"></param>
        public void Visit(Element1 e)
        {
            Console.WriteLine("Visitor1 visit Element1");
        }

        /// <summary>
        /// Visitor1对元素ElementN实现的一种具体操作（算法）
        /// </summary>
        /// <param name="e"></param>
        public void Visit(ElementN e)
        {
            Console.WriteLine("Visitor1 visit ElementN");
        }
    }
}
