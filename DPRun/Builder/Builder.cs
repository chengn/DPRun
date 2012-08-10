using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Builder
{
    public interface Builder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetProduct();
    }
}
