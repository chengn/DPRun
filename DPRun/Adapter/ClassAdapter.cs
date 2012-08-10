using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Adapter
{
    /// <summary>
    /// 适配器，将Target中的操作适配为Adaptee中的操作
    /// 将字母中的顺序适配为数字中的顺序
    /// </summary>
    public class ClassAdapter : Adaptee, ITarget
    {
        /// <summary>
        /// 字母顺序A适配为数字1，都表示第一个
        /// </summary>
        /// <returns></returns>
        public string OperateA()
        {
            return Operate1();
        }
        /// <summary>
        /// 字母顺序B适配为数字2，都表示第二个
        /// </summary>
        /// <returns></returns>
        public string OperateB()
        {
            return Operate2();
        }
    }
}
