using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Mediator
{
    /// <summary>
    /// 具体的中介者,继承中介者接口
    /// </summary>
    public class ConcreteMediator:Mediator
    {
        /// <summary>
        /// 本中介者所拥有的一个成员列表，这里可以引入观察者模式
        /// </summary>
        private Colleague c1;
        private Colleague c2;

        /// <summary>
        /// 实现变化通知,对注册在这里的成员通知
        /// </summary>
        /// <param name="c"></param>
        public override void ColleagueChanged(Colleague c)
        {
            c1.Action();
            c2.Action();
        }

        /// <summary>
        /// 注册自己的成员
        /// </summary>
        public void CreateConcreteMeadiator()
        {
            this.c1 = new Colleague1(this);
            this.c2 = new ColleagueN(this);

        }

        public Colleague GetColleague1()
        {
            return this.c1;
        }

        public Colleague GetColleague2()
        {
            return this.c2;
        }
    }
}
