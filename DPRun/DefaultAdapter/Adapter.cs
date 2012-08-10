using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.DefaultAdapter
{
    /// <summary>
    /// 适配器，用抽象类来实现接口，
    /// 这样目标类就可以选择性的继承本类而实现接口
    /// </summary>
    public abstract class Adapter:IAdaptee
    {
        public string Operate1() { return null; }

        public string Operate2() { return null; }

        public string OperateA() { return null; }

        public string OperateB() { return null; }
    }
}
