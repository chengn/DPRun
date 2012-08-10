using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.StrategyP
{
    /// <summary>
    /// 具体策略N
    /// </summary>
    public class StrategyN:Strategy
    {
        /// <summary>
        /// 实现具体的算法
        /// </summary>
        public void Algorithm()
        {
            Console.WriteLine("我负责打8折");
        }
    }
}
