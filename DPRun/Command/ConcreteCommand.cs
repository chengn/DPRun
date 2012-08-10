using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.CommandP
{
    /// <summary>
    /// 具体的命令，实现命令接口Command
    /// </summary>
    public class ConcreteCommand:Command
    {
        /// <summary>
        /// 命令的接收者，也可以说是命令载体
        /// </summary>
        private Receiver receiver;

        /// <summary>
        /// 命令的构造函数，参数表明了构建一个命令必须
        /// 同时制定一个命令的接收者，他们的生命收起相同。
        /// </summary>
        /// <param name="receiver"></param>
        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        /// <summary>
        /// 命令执行，作用于本命令指定的接收者
        /// </summary>
        public void Execute()
        {
            receiver.Action();
        }
    }
}
