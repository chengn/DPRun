using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.ObserverP
{
    /// <summary>
    /// 具体观察者
    /// </summary>
    public class ConcreteObserver:Observer
    {
        public void Update()
        {
            //打印对象的编号来显示所有观察者的改变
            Console.WriteLine(this.GetType().Name + this.GetHashCode()+"：I'm Notify");
        }
    }
}
