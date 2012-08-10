using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.VisitorDP
{
    /// <summary>
    /// 待访问的对象结构类
    /// </summary>
    public class ObjectStructure
    {
        /// <summary>
        /// 对象元素池
        /// </summary>
        private IList<Element> elements;
        //private Element element;

        /// <summary>
        /// 对象结构类构造子，创建对象的元素池
        /// </summary>
        public ObjectStructure() 
        {
            this.elements = new List<Element>();
        }
        /// <summary>
        /// 对象结构执行访问，对池中所有的元素访问
        /// </summary>
        /// <param name="visitor"></param>
        public void Action(Visitor visitor)
        {
            foreach (Element e in elements)
            {
                e.Accept(visitor);
            }
        }
        /// <summary>
        /// 对象池中添加元素
        /// </summary>
        /// <param name="e"></param>
        public void Add(Element e)
        {
            elements.Add(e);
        }
    }
}
