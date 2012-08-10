using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DP.FacadeP;

namespace DP.Test
{
    public class FacadeTest
    {
        #region 重构前
        /// <summary>
        /// 没有外观模式时对系统的操作
        /// </summary>
        public static void Test()
        {
            SubSystem1 sys1 = new SubSystem1();
            SubSystem2 sys2 = new SubSystem2();
            SubSystem3 sys3 = new SubSystem3();

            //执行一次放映操作
            sys1.Start();//打开电源
            sys2.TurnOn();//开始操作
            sys3.PlayOn();//调大声音

            sys3.PlayOff();
            sys2.TurnOff();
            sys1.End();
        }
        #endregion

        #region 重构后
        //重构后
        private static SysFacade sys;
        /// <summary>
        /// 用外观模式重构之后对系统的操作
        /// </summary>
        public static void RefactorTest()
        {
            sys = new SysFacade();
            //听音乐
            sys.MusicOn();
            //关闭音乐
            sys.MusicOff();
        }
        #endregion

    }
}
