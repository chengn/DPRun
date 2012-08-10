using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.ObserverP;

namespace DP.Test
{
    /// <summary>
    /// 观察者模式测试类
    /// </summary>
    public class ObserverTest
    {
 
        private static ConcreteSubject subject;
        private static Observer observer1;
        private static Observer observer2;

        public static void Test()
        {
            Console.WriteLine("==============================Observer Test==================================");

            //创建主题
            subject = new ConcreteSubject();
            //创建观察者
            observer1 = new ConcreteObserver();
            observer2 = new ConcreteObserver();
            //登记观察者
            subject.Attach(observer1);
            subject.Attach(observer2);

            //改变主题状态
            subject.Change("changed");

        }
    }
}
