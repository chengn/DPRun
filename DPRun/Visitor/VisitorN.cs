using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.VisitorDP
{
    /// <summary>
    /// 访问器N，实现访问器接口，对元素结构的第N类操作规则（算法）
    /// </summary>
    public class VisitorN:Visitor
    {
        /// <summary>
        /// VisitorN对元素Element1实现的一种具体操作（算法）
        /// </summary>
        /// <param name="e"></param>
        public void Visit(Element1 e)
        {
            Console.WriteLine("VisitorN visit Element1");
        }

        /// <summary>
        /// VisitorN对元素ElementN实现的一种具体操作（算法）
        /// </summary>
        /// <param name="e"></param>
        public void Visit(ElementN e)
        {
            Console.WriteLine("VisitorN visit ElementN");
        }
    }
}
