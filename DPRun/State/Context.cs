using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.StateP
{
    /// <summary>
    /// 环境角色类，作为状态运行的环境
    /// </summary>
    public class Context
    {
        //定义自己的一个状态
        private IState state;
        /// <summary>
        /// 加载状态
        /// </summary>
        /// <param name="state"></param>
        public void SetState(IState state)
        {
            this.state = state;
        }
        /// <summary>
        /// 代理方法，用于执行状态的通用方法Method
        /// </summary>
        public void Method()
        {
            state.Method();
        }
    }
}
