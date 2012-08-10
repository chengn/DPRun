using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Mediator
{
    /// <summary>
    /// 中介者所拥有的成员的一个抽象,定义共同的属性和方法。
    /// </summary>
    public abstract class Colleague
    {
        /// <summary>
        /// 拥有一个中介者
        /// </summary>
        private Mediator mediator;

        /// <summary>
        /// 构造方法，创建的时候就拥有一个中介者
        /// </summary>
        /// <param name="m"></param>
        public Colleague(Mediator m)
        {
            this.mediator = m;
        }

        public Mediator GetMediator()
        {
            return this.mediator;
        }

        /// <summary>
        /// 所有的子类都需要实现的一个方法,负责子类自己的操作
        /// </summary>
        public abstract void Action();

        public void Change()
        {
            mediator.ColleagueChanged(this);
        }

    }
}
