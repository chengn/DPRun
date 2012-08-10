using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.VisitorDP
{
    /// <summary>
    /// 元素1的成员
    /// </summary>
    public class Element1:Element
    {
        /// <summary>
        /// 接受一个访问器，实现接口的方法
        /// </summary>
        /// <param name="v"></param>
        public void Accept(Visitor v)
        {
            v.Visit(this);
        }
        /// <summary>
        /// 元素1自己的操作方法
        /// </summary>
        /// <returns></returns>
        public string Method()
        {
            return "Element1's Method";
        }
    }
}
