using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.VisitorDP
{
    /// <summary>
    /// 元素接口
    /// </summary>
    public interface Element
    {
        /// <summary>
        /// 接受一个访问器
        /// </summary>
        /// <param name="v"></param>
        void Accept(Visitor v);
    }
}
