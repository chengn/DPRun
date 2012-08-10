using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Proxy
{
    /// <summary>
    /// 具体主题
    /// </summary>
    public class RealSubject :Subject
    {
        public RealSubject()
        { }

        public void Request()
        {
            Console.WriteLine("Real Subject Request");
        }
    }
}
