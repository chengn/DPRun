using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Proxy
{
    /// <summary>
    /// 代理主题
    /// </summary>
    public class ProxySubject:Subject
    {
        private RealSubject realSubject;

        public ProxySubject()
        { }

        /// <summary>
        /// 代理或转发请求
        /// </summary>
        public void Request()
        {
            PreRequest();
            if (realSubject == null)
                realSubject = new RealSubject();
            realSubject.Request();//代理转发
            PostRequest();
        }

        public void PreRequest()
        { }

        public void PostRequest()
        { }
    }
}
