using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.CompilerServices;

namespace DP.ObserverP
{
    /// <summary>
    /// 具体主题，主题接口的实现
    /// </summary>
    public class ConcreteSubject:Subject
    {
        private IList<Observer> observerList = new List<Observer>();
        private string state;

        /// <summary>
        /// 增加观察者
        /// </summary>
        /// <param name="observer"></param>
        [MethodImpl(MethodImplOptions.Synchronized)] //引入包using System.Runtime.CompilerServices;
        public void Attach(Observer observer)
        {
            if (!observerList.Contains(observer))
                observerList.Add(observer);
        }

        /// <summary>
        /// 删除观察者
        /// </summary>
        /// <param name="observer"></param>
        [MethodImpl(MethodImplOptions.Synchronized)] //引入包using System.Runtime.CompilerServices;
        public void Detach(Observer observer)
        {
            observerList.Remove(observer);
        }

        /// <summary>
        /// 变更通知
        /// </summary>
        public void Notify()
        {
            foreach (Observer o in observerList)
                o.Update();
        }

        /// <summary>
        /// 用于测试的方法
        /// </summary>
        /// <param name="state"></param>
        public void Change(string state)
        {
            this.state = state;
            Notify();
        }
    }
}
