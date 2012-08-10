using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.Memento;

namespace DP.Test
{
    public class MementoTest
    {
        private static Originator o = new Originator();
        private static CareTaker c = new CareTaker();
        public static void Test()
        {
            Console.WriteLine("==============================Memento Test==================================");
            o.SetState("On");
            c.SaveMemento(o.CreateMemento());

            Console.WriteLine("第一次为" + o.GetState());

            o.SetState("Off");

            Console.WriteLine("第二次为" + o.GetState());

            o.RestoreMemento(c.retrieveMemento());

            Console.WriteLine("恢复到上一次为" + o.GetState());
        }
    }
}
