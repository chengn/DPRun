using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.FacadeP
{
    /// <summary>
    /// 封装子系统的系统外观
    /// </summary>
    public class SysFacade
    {
        private SubSystem1 sys1 = new SubSystem1();
        private SubSystem2 sys2 =  new SubSystem2();
        private SubSystem3 sys3 = new SubSystem3();

        /// <summary>
        /// 打开音乐
        /// </summary>
        public void MusicOn()
        {
            //打开电脑
            sys1.Start();
            //打开音箱
            sys2.TurnOn();
            //打开播放器播放
            sys3.PlayOn();
        }

        /// <summary>
        /// 关闭音乐
        /// </summary>
        public void MusicOff()
        {
            //关闭播放器
            sys3.PlayOff();
            //关闭音箱
            sys2.TurnOff();
            //关闭电脑
            sys1.End();
        }
    }
}
