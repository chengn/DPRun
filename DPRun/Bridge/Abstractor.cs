using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.BridgeP
{
    /// <summary>
    /// 抽象者
    /// </summary>
    public abstract class Abstractor
    {
        /// <summary>
        /// 用来桥接的分离器
        /// </summary>
        protected Implementor impl;

        public void SetImplement(Implementor impl)
        {
            this.impl = impl;
        }

        public void Method()
        {
            impl.Method();
        }
    }
}
