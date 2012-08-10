using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.FlyweightP;

namespace DP.Test
{
    /// <summary>
    /// 享元模式测试
    /// </summary>
    public class FlyWeightTest
    {
        public static void Test()
        {
            Console.WriteLine("============================Flyweight================================");
            Factory f = new Factory();
            IFlyweight fly = f.GetFlyweight("a");
            fly.Method("First Value");//外部状态 First Value = 内部状态a

            fly = f.GetFlyweight("b");
            fly.Method("Second Value");//外部状态 Second Value = 内部状态b

            //第三个值，已经存在的对象，会共享这个对象，也就是外部有三个值，但是系统实际不会产生这个对象
            fly = f.GetFlyweight("a");
            fly.Method("Third Value");//外部状态 Third Value = 内部状态a

            Console.WriteLine("实际对象个数=" + f.FlyweightCount);//实际对象个数=2

        }
    }
}
