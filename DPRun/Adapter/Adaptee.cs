using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Adapter
{
    /// <summary>
    /// 适配源
    /// 数字表示的顺序
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        /// 数字1表示第一个
        /// </summary>
        /// <returns></returns>
        public string Operate1()
        {
            return "say : I'm 1!";
        }
        /// <summary>
        /// 数字2表示第二个
        /// </summary>
        /// <returns></returns>
        public string Operate2()
        {
            return "say:I'm 2!";
        }
    }
}
