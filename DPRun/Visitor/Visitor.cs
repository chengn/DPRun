using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.VisitorDP
{
    /// <summary>
    /// 访问者接口
    /// </summary>
    public interface Visitor
    {
        void Visit(Element1 e);
        void Visit(ElementN e);
    }
}
