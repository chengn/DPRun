using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.IteratorDP
{
    /// <summary>
    /// 具体的聚集类型
    /// </summary>
    public class ConcreteAggregate:Aggregate
    {
        private object[] obj = {1,2,3,4,5,6,7,8,9,10};

        /// <summary>
        /// 创建本聚集的迭代器
        /// </summary>
        /// <returns></returns>
        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        /// <summary>
        /// 聚集的容量
        /// </summary>
        /// <returns></returns>
        public int Size()
        { 
            return obj.Length;
        }

        /// <summary>
        /// 得到聚集中指定的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object getItem(int index)
        {
            return obj[index];
        }

    }
}
