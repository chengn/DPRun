using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.IteratorDP
{
    /// <summary>
    /// 迭代器接口
    /// </summary>
    public interface Iterator
    {
        void First();
        void Next();
        bool IsDone();
        object currentItem();
    }
}
