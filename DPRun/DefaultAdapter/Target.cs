using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.DefaultAdapter
{
    /// <summary>
    /// 目标类，实现用字母表示顺序， 需要适配以实现Adaptee接口
    /// </summary>
    public class Target:Adapter
    {
        public string OperateA() 
        {
            return "Say : I'm A";
        }

        public string OperateB()
        {
            return "Say : I'm B";
        }
    }
}
