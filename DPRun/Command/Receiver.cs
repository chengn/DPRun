using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.CommandP
{
    /// <summary>
    /// 命令的接收者，提供命令的具体执行细节
    /// </summary>
    public class Receiver
    {
        public Receiver()
        { }

        /// <summary>
        /// 命令接收者执行具体的命令操作，这里包含了命令的具体信息
        /// </summary>
        public void Action()
        {
            Console.WriteLine("Action");
        }
    }
}
