using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.Mediator;

namespace DP.Test
{
    /// <summary>
    /// 中介者客户端
    /// </summary>
    public class MediatorTest
    {
        public static void Test()
        {
            Console.WriteLine("==============================Mediator Test==================================");
            ConcreteMediator mediator = new ConcreteMediator();
            mediator.CreateConcreteMeadiator();

            Colleague c = new Colleague1(mediator);
            //Colleague cN = new ColleagueN(mediator);

            mediator.ColleagueChanged(c);
        }
    }
}
