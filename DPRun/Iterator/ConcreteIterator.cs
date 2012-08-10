using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.IteratorDP
{
    /// <summary>
    /// 针对某个聚集的具体的迭代器
    /// </summary>
    public class ConcreteIterator :Iterator
    {
        private ConcreteAggregate agg;
        private int index = 0;
        private int size = 0;

        /// <summary>
        /// 针对某个聚集的操作，加载需要操作的聚集
        /// </summary>
        /// <param name="agg"></param>
        public ConcreteIterator(ConcreteAggregate agg)
        {
            this.agg = agg;
            this.size = agg.Size();
            this.index = 0;
        }

        public void First()
        {
            this.index = 0;
        }

        public void Next()
        {
            if (this.index < this.size)
                index++;
        }

        public bool IsDone()
        {
            return (this.index >= this.size);
        }

        public object currentItem()
        {
            return agg.getItem(index);
        }
    }
}
