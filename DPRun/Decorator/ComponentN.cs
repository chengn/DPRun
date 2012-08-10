using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.DecoratorP
{
    /// <summary>
    /// 被装饰的类
    /// </summary>
    public class ComponentN:Component
    {
        public ComponentN()
        { }

        public string Method()
        {
            return "hello world!";
        }
    }
}
