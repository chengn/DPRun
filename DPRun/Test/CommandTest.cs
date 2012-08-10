using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.CommandP;

namespace DP.Test
{
    /// <summary>
    /// 命令模式测试类
    /// </summary>
    public class CommandTest
    {
        public static void Test()
        {
            Console.WriteLine("==============================Command Test==================================");

            Receiver receiver = new Receiver();
            Command cmd = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker(cmd);
            invoker.Action();//调用者执行
        }
    }
}
