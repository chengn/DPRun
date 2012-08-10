using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.DefaultAdapter
{
    /// <summary>
    /// 需要适配的接口
    /// 表示顺序的接口，既有字母表示的也有数字表示的
    /// </summary>
    public interface IAdaptee
    {
        string Operate1();
        string Operate2();
        string OperateA();
        string OperateB();
    }
}
