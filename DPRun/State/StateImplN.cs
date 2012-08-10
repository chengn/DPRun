using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.StateP
{
    /// <summary>
    /// 状态接口的第N个实现
    /// </summary>
    public class StateImplN:IState
    {
        /// <summary>
        /// 实现接口的操作方法
        /// </summary>
        public void Method()
        {
            Console.WriteLine("State_N");
        }
    }
}
