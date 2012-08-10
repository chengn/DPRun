using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Prototype
{
    /// <summary>
    /// 定义克隆方法的接口，实现本接口的类都具有克隆方法
    /// </summary>
    public interface IProduct
    {
        IProduct Clone();
    }
}
