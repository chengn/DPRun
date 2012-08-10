using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.StrategyP
{
    /// <summary>
    /// 环境角色类
    /// </summary>
    public class Context
    {
        //引入策略
        private Strategy strategy;

        /// <summary>
        /// 动态分配策略，这样就可以根据需要动态的调整算法了
        /// </summary>
        /// <param name="strategy"></param>
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        /// <summary>
        /// 策略执行接口,这里执行动态选择的具体策略所表达的算法
        /// </summary>
        public void ContextInterface()
        {
            strategy.Algorithm();
        }
    }
}
