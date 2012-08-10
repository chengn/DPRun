using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Adapter
{
    /// <summary>
    /// 对象适配器，和ClassAdapter适配器效果一样
    /// 将Target中的操作适配为Adaptee中的操作
    /// 将字母中的顺序适配为数字中的顺序
    /// </summary>
    public class ObjectAdapter:ITarget
    {
        //定义适配源
        private Adaptee adaptee;
        /// <summary>
        /// 构造适配源
        /// </summary>
        /// <param name="adaptee"></param>
        public ObjectAdapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        /// <summary>
        /// 字母顺序A适配为数字1，都表示第一个
        /// </summary>
        /// <returns></returns>
        public string OperateA()
        {
            return adaptee.Operate1();
        }
        /// <summary>
        /// 字母顺序B适配为数字2，都表示第二个
        /// </summary>
        /// <returns></returns>
        public string OperateB()
        {
            return adaptee.Operate2();
        }
    }
}
