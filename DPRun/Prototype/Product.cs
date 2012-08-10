using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Prototype
{
    /// <summary>
    /// 实现深复制，自身具有ProductPart类对象的引用，
    /// 需要创建其引用对象的副本，也就是ProductPart也要穿件一个副本
    /// </summary>
    public class Product:IProduct
    {
        private string id;
        private ProductPart pProto;
        /// <summary>
        /// 默认构造方法
        /// </summary>
        public Product()
        { }
        /// <summary>
        /// 带有属性的构造方法,可用于深复制构造
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pPhoto"></param>
        public Product(string id, ProductPart pPhoto)
        {
            this.id = id;
            this.pProto = pProto;
        }
        /// <summary>
        /// 默认克隆方法，是深复制，把对象的引用一起复制，pProto就是本对象的一个引用
        /// </summary>
        /// <returns></returns>
        public IProduct Clone()
        {
            return DeepClone();
        }
        /// <summary>
        /// 浅复制方法，复制对象的属性，对象的引用还是指向原来的引用对象
        /// </summary>
        /// <returns></returns>
        public IProduct ShallowClone()
        {
            return new Product(this.id,this.pProto);
        }

        /// <summary>
        /// 深复制，复制对象的属性和引用，对象的引用是原来引用的对象的副本而非本身
        /// </summary>
        /// <returns></returns>
        public IProduct DeepClone()
        {
            return new Product(this.id, (ProductPart)this.pProto.Clone());
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public ProductPart PProto
        {
            get { return this.pProto; }
            set { this.pProto = value; }
        }
    }
}
