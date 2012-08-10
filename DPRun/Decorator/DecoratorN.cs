using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.DecoratorP
{
    /// <summary>
    /// 装饰者n
    /// </summary>
    public class DecoratorN:Decorator
    {
        /// <summary>
        /// 使用父类的构造方法
        /// </summary>
        /// <param name="component"></param>
        public DecoratorN(Component component)
            : base(component)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Method()
        {
            return base.Method() + AddBehavior();//java中，super.Method();
        }

        public string AddBehavior()
        {
            return "Add DecoratorN.";
        }
    }
}
