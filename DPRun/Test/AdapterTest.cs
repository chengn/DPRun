using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.Adapter;

namespace DP.Test
{
    /// <summary>
    /// 适配器模式客户端代码
    /// </summary>
    public class AdapterTest
    {
        public static void Test()
        {
            //适配之前
            ITarget letter = new Target();
            string seqA = letter.OperateA();
            string seqB = letter.OperateB();
            Console.WriteLine(seqA);//Say : I'm A
            Console.WriteLine(seqB);//Say : I'm B

            //用适配模式重构之后，类适配模式
            ITarget number = new ClassAdapter();
            string seq1 = number.OperateA();
            string seq2 = number.OperateB();
            Console.WriteLine(seq1);//say : I'm 1!
            Console.WriteLine(seq2);//say:I'm 2!

            //用适配模式重构之后，对象适配模式
            Adaptee adaptee = new Adaptee();
            ITarget num = new ObjectAdapter(adaptee);
            string seqNum1 = num.OperateA();
            string seqNum2 = num.OperateB();
            Console.WriteLine(seqNum1);//say : I'm 1!
            Console.WriteLine(seqNum2);//say:I'm 2!
        }
    }
}
