using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.Proxy;

namespace DP.Test
{
    /// <summary>
    /// 代理模式测试
    /// </summary>
    public class ProxyTest
    {
        public static void Test()
        {
            Console.WriteLine("==============================Proxy Test==================================");

            //使用代理
            Subject proxySubject = new ProxySubject();
            proxySubject.Request();

            //不使用代理
            Subject realSubject = new RealSubject();
            realSubject.Request();
        }
    }
}
