using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Adapter
{
    /// <summary>
    /// 适配目标接口
    /// </summary>
    public interface ITarget
    {
        string OperateA();//字母表示第一个
        string OperateB();//字母表示第二个
    }
}
