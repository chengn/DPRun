using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.BridgeP;

namespace DP.Test
{
    public class BridgeTest
    {
        public static void Test()
        {
            Abstractor abstractor = new RefinedAbstractor();
            abstractor.SetImplement(new ImplementA());
            abstractor.Method();

            abstractor.SetImplement(new ImplementB());
            abstractor.Method();
        }
    }
}
