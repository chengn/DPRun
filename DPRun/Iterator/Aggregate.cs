using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.IteratorDP
{
    /// <summary>
    /// 聚集接口
    /// </summary>
    public interface Aggregate
    {
        Iterator CreateIterator();
    }
}
