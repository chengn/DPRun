using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.CommandP
{
    /// <summary>
    /// 命令调用者
    /// </summary>
    public class Invoker
    {
        /// <summary>
        /// 需要调用的命令
        /// </summary>
        private Command cmd;

        /// <summary>
        /// 调用者的生存根本是拥有一个命令
        /// </summary>
        /// <param name="cmd"></param>
        public Invoker(Command cmd)
        {
            this.cmd = cmd;
        }

        /// <summary>
        /// 行动吧，执行一个命令
        /// </summary>
        public void Action()
        {
            cmd.Execute();
        }
    }
}
