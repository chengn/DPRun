using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.IteratorDP;

namespace DP.Test
{
    /// <summary>
    /// 迭代器模式测试类
    /// </summary>
    public class IteratorTest
    {
        /// <summary>
        /// 迭代器模式的测试
        /// </summary>
        public static void Test()
        {
            Console.WriteLine("==============================Iterator Test==================================");
            Iterator ite;
            Aggregate agg = new ConcreteAggregate();
            ite = agg.CreateIterator();
            while (!ite.IsDone())
            {
                Console.Write(ite.currentItem().ToString());
                ite.Next();
            }
        }
    }
}
