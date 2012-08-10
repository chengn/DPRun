using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.ObserverP
{
    /// <summary>
    /// 观察者模式中主题
    /// </summary>
    public interface Subject
    {
        /// <summary>
        /// 添加一个观察者
        /// </summary>
        void Attach(Observer observer);
        /// <summary>
        /// 删除一个观察者
        /// </summary>
        void Detach(Observer observer);
        /// <summary>
        /// 通知所有观察者
        /// </summary>
        void Notify();
    }
}
