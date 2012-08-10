using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.ChainOfResponsibility
{
    /// <summary>
    /// 具体的责任传递句柄
    /// </summary>
    public class ConcreteHandle:Handle
    {
        /// <summary>
        /// 请求传递给下一个责任人
        /// </summary>
        public override void HandleRequest()
        {
            if (next != null)
            {
                Pass();
                next.HandleRequest();
            }
            else
            {
                //没有传递者的处理
                Stop();
            }
        }

        /// <summary>
        /// 用于测试的方法，显示没有责任人可以传递了
        /// </summary>
        private void Stop()
        {
            Console.WriteLine(this.GetType().ToString() + 
                this.GetHashCode().ToString() + 
                " can't pass,Request is stop");
        }
        /// <summary>
        /// 用于测试的方法，表明当前的责任人在传递责任
        /// </summary>
        private void Pass()
        {
            Console.WriteLine(this.GetType().ToString() + 
                this.GetHashCode().ToString() + 
                " is pass");
        }
    }
}
