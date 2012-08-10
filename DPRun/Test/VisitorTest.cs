using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.VisitorDP;

namespace DP.Test
{
    /// <summary>
    /// 访问者模式客户端测试类
    /// </summary>
    public class VisitorTest
    {
        /// <summary>
        /// 对象结构类
        /// </summary>
        private static ObjectStructure objst;
        /// <summary>
        /// 访问者，用于对象结构类的访问
        /// </summary>
        private static Visitor visitor;

        /// <summary>
        /// 客户端测试代码
        /// </summary>
        public static void Test()
        {
            Console.WriteLine("==============================Visitor Test==================================");
            //创建一个结构对象
            objst = new ObjectStructure();
            //增加一个元素
            objst.Add(new Element1());
            //增加一个元素N
            objst.Add(new ElementN());
            //创建一个新的访问者1
            visitor = new Visitor1();
            //访问者访问对象结构
            objst.Action(visitor);
            //使用访问者N
            visitor = new VisitorN();
            //元素的对象结构加载一个访问者
            objst.Action(visitor);

        }
    }
}
