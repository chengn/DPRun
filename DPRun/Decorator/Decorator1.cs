using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.DecoratorP
{
    /// <summary>
    /// 装饰者1
    /// </summary>
    public class Decorator1:Decorator
    {
        /// <summary>
        /// 继承装饰者的构造方法
        /// </summary>
        /// <param name="component"></param>
        public Decorator1(Component component)
            : base(component)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Method()
        {
            return base.Method() + AddBehavior();
        }
        /// <summary>
        /// 具体的装饰者添加行为
        /// </summary>
        /// <returns></returns>
        public string AddBehavior()
        {
            return "Add Decorator1.";
        }
    }
}
