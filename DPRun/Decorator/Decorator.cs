using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.DecoratorP
{
    public class Decorator:Component
    {
        private Component component;
        /// <summary>
        /// 构造函数，初始化需要装饰的对象
        /// </summary>
        /// <param name="component"></param>
        public Decorator(Component component)
        {
            this.component = component;
        }
        /// <summary>
        /// 自己的构造函数
        /// </summary>
        public Decorator()
        { 
        }
        /// <summary>
        /// 装饰者方法
        /// </summary>
        /// <returns></returns>
        public string Method()
        {
            return component.Method();
        }
    }
}
