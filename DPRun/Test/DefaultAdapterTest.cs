using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.DefaultAdapter;

namespace DP.Test
{
    /// <summary>
    /// 缺省适配模式客户端代码
    /// </summary>
    public class DefaultAdapterTest
    {
        public static void Test()
        {
            //Target实现了接口IAdaptee
            IAdaptee target = new Target();
            string letterA = target.OperateA();
            string letterB = target.OperateB();
            Console.WriteLine(letterA);//Say : I'm A
            Console.WriteLine(letterB);//Say : I'm B
        }
    }
}
