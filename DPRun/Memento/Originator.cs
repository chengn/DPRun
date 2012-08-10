using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Memento
{
    /// <summary>
    /// 用于创建备忘录的原发器，记录当前的内部状态
    /// </summary>
    public class Originator
    {
        /// <summary>
        /// 当前的状态
        /// </summary>
        private string state;

        /// <summary>
        /// 创建一个当前状态的备忘录
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(this.state);
        }

        /// <summary>
        /// 恢复当前状态为备忘录所保存的状态
        /// </summary>
        /// <param name="memento"></param>
        public void RestoreMemento(Memento memento)
        {
            this.state = memento.GetState();
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
