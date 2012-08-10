using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Mediator
{
    /// <summary>
    /// 中介者的成员，用N表明有多个成员
    /// </summary>
    public class ColleagueN:Colleague
    {
        public ColleagueN(Mediator m)
            : base(m)
        { }

        /// <summary>
        /// 执行自己的操作
        /// </summary>
        public override void Action()
        {
            Console.WriteLine(this.GetType().Name + "    Action");
        }
    }
}
