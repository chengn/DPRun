using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.ObserverP
{
    /// <summary>
    /// 观察者
    /// </summary>
    public interface Observer
    {
        //接收订阅的更新通知
        void Update();
    }
}
