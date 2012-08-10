using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.FlyweightP
{
    /// <summary>
    /// 享元工厂
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// 享元对象池
        /// </summary>
        private IDictionary<string, IFlyweight> pools = new Dictionary<string, IFlyweight>();

        /// <summary>
        /// 享元工厂，生产享元对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IFlyweight GetFlyweight(string key)
        {
            if (pools.ContainsKey(key))
                return pools[key];
            else
            {
                IFlyweight fly = new FlyweightA(key);
                pools.Add(key, fly);
                return fly;
            }

        }

        /// <summary>
        /// 用于测试享元对象的数量，不作为享元模式的结构
        /// </summary>
        public int FlyweightCount
        {
            get { return pools.Count; }
        }
    }
}
