using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Mediator
{
    /// <summary>
    /// 中介者的成员1
    /// </summary>
    public class Colleague1:Colleague
    {
        public Colleague1(Mediator m):base(m)
        {   
        }

        /// <summary>
        /// 接到中介者通知的方法,实现自己的操作
        /// </summary>
        public override void Action()
        {
            Console.WriteLine(this.GetType().Name + "   Action");
        }
    }
}
