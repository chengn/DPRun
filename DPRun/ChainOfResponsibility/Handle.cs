using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.ChainOfResponsibility
{
    /// <summary>
    /// 责任传递句柄抽象类
    /// </summary>
    public abstract class Handle
    {
        //下一个责任人
        protected Handle next;
        /// <summary>
        /// 责任的传递，具体句柄实现
        /// </summary>
        public abstract void HandleRequest();

        /// <summary>
        /// 动态设置下一责任人
        /// </summary>
        /// <param name="next"></param>
        public void SetNext(Handle next)
        {
            this.next = next;
        }
        /// <summary>
        /// 获得下一责任人
        /// </summary>
        /// <returns></returns>
        public Handle GetNext()
        {
            return this.next;
        }
    }
}
