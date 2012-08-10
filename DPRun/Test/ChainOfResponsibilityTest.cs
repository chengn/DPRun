using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.ChainOfResponsibility;

namespace DP.Test
{
    /// <summary>
    /// 责任链模式测试类
    /// </summary>
    public class ChainOfResponsibilityTest
    {
        private static Handle handle1, handle2;

        public static void Test()
        {
            Console.WriteLine("============ ChainOfResponsibility Test=============================");

            handle1 = new ConcreteHandle();
            handle2 = new ConcreteHandle();

            //设置了传递的顺序
            handle1.SetNext(handle2);
            handle1.HandleRequest();
        }
    }
}
