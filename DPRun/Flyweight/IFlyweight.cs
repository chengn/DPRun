using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.FlyweightP
{
    /// <summary>
    /// 享元对象接口
    /// </summary>
    public interface IFlyweight
    {
        /// <summary>
        /// 通过外部状态来操作享元对象
        /// 外部状态是享元对象对外提供服务的标识
        /// </summary>
        /// <param name="extrinsicState"></param>
        void Method(string extrinsicState);
    }
}
