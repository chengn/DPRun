using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.CompositeP
{
    /// <summary>
    /// 树干，相当于一颗子树
    /// </summary>
    public class Composite:Component
    {
        private string name;
        /// <summary>
        /// 树干下的结点
        /// </summary>
        private IList<Component> cponents = new List<Component>();

        public Composite(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 增加结点
        /// </summary>
        /// <param name="c"></param>
        public void Add(Component c)
        {
            cponents.Add(c);
        }
        /// <summary>
        /// 删除结点
        /// </summary>
        /// <param name="c"></param>
        public void Remove(Component c)
        {
            cponents.Remove(c);
        }
        /// <summary>
        /// 取得指定结点
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Component GetChild(int index)
        {
            return cponents[index];
        }

        #region 具体的操作
        /// <summary>
        /// 树枝的操作
        /// </summary>
        public void Method()
        {
            //为了更好的说明结构，打印出来树干的名称
            Console.WriteLine(this.name);
            //执行所有子结点的操作
            foreach (Component c in cponents)
            {
                c.Method();
            }
        }
        #endregion
    }
}
