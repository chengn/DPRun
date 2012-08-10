using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.TemplateMethodP
{
    /// <summary>
    /// 模板类
    /// </summary>
    public abstract class AbstractClass
    {
        /// <summary>
        /// 定义算法骨架，算法步骤,注意模板方法不是抽象的方法
        /// </summary>
        public void TemplateMethod()
        {
            PrimitiveMethod1();
            PrimitiveMethod2();
        }
        //算法的特定步骤，在子类中可以重新定义
        //步骤1
        protected abstract void PrimitiveMethod1();
        //步骤二
        protected abstract void PrimitiveMethod2();
    }
}
