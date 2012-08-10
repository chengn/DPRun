using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.StateP
{
    /// <summary>
    /// 状态接口，将所有的状态抽象起来
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// 提取公有的行为方法
        /// </summary>
        void Method();
    }
}
