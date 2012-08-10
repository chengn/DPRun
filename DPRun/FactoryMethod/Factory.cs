using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.FactoryMethod
{
    /// <summary>
    /// 说明：工厂接口，由生产具体产品的工厂实现
    /// 作者：Truecn
    /// 日期：2011-04-16
    /// </summary>
    public interface Factory
    {
        Product CreateProduct();
    }
}
