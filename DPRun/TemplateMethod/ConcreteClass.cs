using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.TemplateMethodP
{
    /// <summary>
    /// 模板的子类，定义算法的步骤的具体实现
    /// </summary>
    public class ConcreteClass:AbstractClass
    {
        /// <summary>
        /// 定义算法第一部分
        /// </summary>
        protected override void PrimitiveMethod1()
        {
            Console.WriteLine("算法第一部分");
        }

        /// <summary>
        /// 定义算法第二部分
        /// </summary>
        protected override void PrimitiveMethod2()
        {
            Console.WriteLine("算法第二部分");
        }
    }
}
