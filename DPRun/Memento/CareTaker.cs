using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Memento
{
    /// <summary>
    /// 负责保存备忘录的管理员
    /// </summary>
    public class CareTaker
    {
        /// <summary>
        /// 备忘录
        /// </summary>
        private Memento memento;

        /// <summary>
        /// 返回所拥有的备忘录
        /// </summary>
        /// <returns></returns>
        public Memento retrieveMemento()
        {
            return this.memento;
        }

        /// <summary>
        /// 保存一个备忘录
        /// </summary>
        /// <param name="memento"></param>
        public void SaveMemento(Memento memento)
        {
            this.memento = memento;
        }
    }
}
