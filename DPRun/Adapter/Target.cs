using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Adapter
{
    /// <summary>
    /// 适配前接口的实现
    /// 字母表示的顺序
    /// </summary>
    public class Target:ITarget
    {
        /// <summary>
        /// 字母A表示第一个
        /// </summary>
        /// <returns></returns>
        public string OperateA()
        {
            return "Say : I'm A";
        }
        /// <summary>
        /// 字母B表示第二个
        /// </summary>
        /// <returns></returns>
        public string OperateB()
        {
            return "Say : I'm B";
        }
    }
}
