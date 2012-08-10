using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.TemplateMethodP;

namespace DP.Test
{
    /// <summary>
    /// 模板方法模式测试类
    /// </summary>
    public class TemplateMethodTest
    {
        public static void Test()
        {
            //定义模板类
            AbstractClass template = new ConcreteClass();
            //执行模板方法定义的算法
            template.TemplateMethod();
        }
    }
}
