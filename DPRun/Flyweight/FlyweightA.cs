using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.FlyweightP
{
    /// <summary>
    /// 具体享元
    /// </summary>
    public class FlyweightA : IFlyweight
    {
        /// <summary>
        /// 享元内部状态，作为享元对象的内部标识
        /// </summary>
        private string instrinsicState;

        /// <summary>
        /// 构造函数，确定享元内部状态
        /// </summary>
        /// <param name="inState"></param>
        public FlyweightA(string inState)
        {
            this.instrinsicState = inState;
        }

        /// <summary>
        /// 具体享元的操作
        /// </summary>
        /// <param name="extrinsicState"></param>
        public void Method(string extrinsicState)
        {
            Console.WriteLine("外部状态 " + extrinsicState + " = 内部状态" + instrinsicState);
        }
    }
}
