using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.StrategyP;

namespace DP.Test
{
    /// <summary>
    /// 策略模式测试类
    /// </summary>
    public class StrategyTest
    {
        public static void Test()
        {
            Console.WriteLine("==============================Strategy Test==================================");

            //执行算法1,促销打5折
            Context context1 = new Context(new Strategy1());
            context1.ContextInterface();//我负责打5折

            //执行算法N，平常打8折
            Context contextN = new Context(new StrategyN());
            contextN.ContextInterface();//我负责打8折
        }
    }
}
