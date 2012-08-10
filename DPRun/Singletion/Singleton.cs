using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.CompilerServices;

namespace DP.Singletion
{
    /// <summary>
    /// 说明：单例模式
    /// 作者：Truecn
    /// 日期：2011-04-14
    /// </summary>
    public class Singleton
    {
        //定义单一的实例
        private static Singleton instance = new Singleton();
        //private static Singleton instance = null;延迟加载时候使用

        /// <summary>
        /// 构造方法为私有，不能被别人随便构造本类的实例，
        /// 这个是单例模式的关键
        /// </summary>
        private Singleton()
        { }

        /// <summary>
        /// 取得本类实例的入口，所有本类的实例都是通过这个方法取得。
        /// </summary>
        /// <returns></returns>
        //[MethodImpl(MethodImplOptions.Synchronized)]//使用延迟加载时，为了线程安全而使用
        public static Singleton GetInstance()
        {
            //延迟加载使用==================
            //if (instance == null)
            //    instance = new Singleton();
            //正常使用======================
            return instance;
        }

        /// <summary>
        /// 本类的其他操作成员方法
        /// </summary>
        /// <returns></returns>
        public string Method()
        {
            return "hello world!";
        }
    }
}
