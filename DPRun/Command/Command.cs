using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.CommandP
{
    /// <summary>
    /// 命令借口，所有的具体命令都实现本借口
    /// </summary>
    public interface Command
    {
        /// <summary>
        /// 用于执行命令的接口方法
        /// </summary>
        void Execute();
    }
}
