using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.VisitorDP
{
    /// <summary>
    /// 元素N
    /// </summary>
    public class ElementN:Element
    {
        /// <summary>
        /// 接受一个访问器
        /// </summary>
        /// <param name="v"></param>
        public void Accept(Visitor v)
        {
            v.Visit(this);
        }
        /// <summary>
        /// 元素N自己的操作方法
        /// </summary>
        /// <returns></returns>
        public string Method()
        {
            return "ElementN's Method";
        }
    }
}
