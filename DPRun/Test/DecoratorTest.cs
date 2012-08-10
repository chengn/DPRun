using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.DecoratorP;

namespace DP.Test
{
    /// <summary>
    /// 测试装饰者模式
    /// </summary>
    public class DecoratorTest
    {
        public static void Test()
        {
            //被装饰的对象
            Component c = new ComponentN();
            //装饰者1
            Decorator1 c1 = new Decorator1(c);
            //装饰者n
            DecoratorN cN = new DecoratorN(c);

            string result = c.Method();//hello world!
            string resultc1 = c1.Method();//hello world!Add Decorator1.
            string resultcN = cN.Method();//hello world!Add DecoratorN.

            Console.WriteLine(result);
            Console.WriteLine(resultc1);
            Console.WriteLine(resultcN);
        }
    }
}
