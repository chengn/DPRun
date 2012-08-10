using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DP.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建型模式-----------------------------------------
            //测试单例模式
            SingletionTest.Test();

            //测试简单工厂模式
            SimpleFactoryTest.Test();

            //测试工厂方法模式
            FactoryMethodTest.Test();

            //测试抽象工厂
            AbstractFactoryTest.Test();

            //测试生成器模式
            BuilderTest.Test();

            //测试原型模式
            ProtoTypeTest.Test();
            
            
            
            //结构型模式-----------------------------------------
            //测试适配器模式
            AdapterTest.Test();

            //测试默认适配模式
            DefaultAdapterTest.Test();

            //测试组合模式
            CompositeTest.Test();

            //测试装饰模式
            DecoratorTest.Test();

            //测试外观模式
            FacadeTest.Test();
            FacadeTest.RefactorTest();

            //测试桥接模式
            BridgeTest.Test();

            //测试代理模式
            ProxyTest.Test();
            
            //测试享元模式
            FlyWeightTest.Test();


            //行为型模式-----------------------------------------
            //测试策略模式
            StrategyTest.Test();

            //测试模板方法
            TemplateMethodTest.Test();

            //测试观察者模式
            ObserverTest.Test();

            //测试状态模式
            StateTest.Test();

            //测试责任链模式
            ChainOfResponsibilityTest.Test();

            //测试命令模式
            CommandTest.Test();

            //测试解释器模式
            InterpreterTest.Test();

            //测试迭代器模式
            IteratorTest.Test();

            //中介者模式
            MediatorTest.Test();

            //备忘录模式
            MementoTest.Test();

            //访问者模式
            VisitorTest.Test();

        }
    }
}
