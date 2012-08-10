using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.StateP
{
    /// <summary>
    /// 状态接口的第1个实现
    /// </summary>
    public class StateImpl1:IState
    {
        /// <summary>
        /// 状态接口中行为方法的具体实现
        /// </summary>
        public void Method()
        {
            Console.WriteLine("State_1");
        }
    }
}
