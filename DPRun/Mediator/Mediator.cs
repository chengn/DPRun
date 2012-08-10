using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Mediator
{
    /// <summary>
    /// 中介者的抽象定义
    /// </summary>
    public abstract class Mediator
    {
        /// <summary>
        /// 所有的中介者都有的一个方法，用于通知其下面注册的成员
        /// </summary>
        /// <param name="c"></param>
        public abstract void ColleagueChanged(Colleague c); 
    }
}
