using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.Prototype;

namespace DP.Test
{
    public class ProtoTypeTest
    {
        /// <summary>
        /// 测试原型模式，浅复制
        /// </summary>
        public static void Test()
        {
            ProductPart p = new ProductPart();
            p.Part1 = "part1";
            p.Part2 = "part2";
            ProductPart pClone = (ProductPart)p.Clone();

            Console.WriteLine(pClone.Part1);
            Console.WriteLine(pClone.Part2);
        }
    }
}
