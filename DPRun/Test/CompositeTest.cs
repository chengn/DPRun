using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.CompositeP;

namespace DP.Test
{
    /// <summary>
    /// 组合模式的测试
    /// </summary>
    public class CompositeTest
    {
        public static void Test()
        {
            //定义一个结点
            Component leaf = new Leaf("file");
            //定义另一个结点1
            Component leaf1 = new Leaf("file1");
            //定义树干1
            Composite cpsite = new Composite("dir1");
            //结点1位于树干1中
            cpsite.Add(leaf1);
            //定义树
            Composite cpnent = new Composite("dir");
            //树中添加树干
            cpnent.Add(cpsite);
            //树中添加树叶
            cpnent.Add(leaf);
            
            //显示树的结构,就会执行所有结点的操作
            cpnent.Method();
        }
    }
}
