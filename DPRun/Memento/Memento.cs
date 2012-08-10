using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Memento
{
    /// <summary>
    /// 备忘录类
    /// </summary>
    public class Memento
    {
        /// <summary>
        /// 备忘录所保存的状态
        /// </summary>
        private string state;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="state"></param>
        public Memento(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return this.state;
        }

        public void SetState(string state)
        {
            this.state = state;
        }
    }
}
