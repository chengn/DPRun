using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.SimpleFactory
{
    /// <summary>
    /// 说明：产品工厂
    /// 作者：Truecn
    /// 日期：2011-04-16
    /// </summary>
    public class Factory
    {
        //预定义产品清单
        private const string PRODUCT1_NAME = "product1";
        private const string PRODUCT2_NAME = "product2";


        /// <summary>
        /// 根据产品清单生产产品，其实就是产品的生产线。
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns>Product</returns>
        public static Product CreatProduct(string TypeName)
        {
            //根据客户要求的产品清单生产对应的产品
            if (TypeName == PRODUCT1_NAME)
            {
                return new Product1();
            }
            else if (TypeName == PRODUCT2_NAME)
            {
                return new Produce2();
            }
            //这里省略好多产品类型的构造，扩展产品需要在这里添加。
            return null;
        }

    }
}
