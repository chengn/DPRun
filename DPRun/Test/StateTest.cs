using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.StateP;

namespace DP.Test
{
    /// <summary>
    /// 状态模式测试类
    /// </summary>
    public class StateTest
    {
        public static void Test()
        {
            Console.WriteLine("==============================State Test==================================");

            //构造一个环境角色
            Context context = new Context();

            //加载一个状态1，并且执行方法
            context.SetState(new StateImpl1());
            context.Method();//State_1

            //加载另一个状态N，并且执行其方法
            context.SetState(new StateImplN());
            context.Method();//State_N
        }
    }
}
