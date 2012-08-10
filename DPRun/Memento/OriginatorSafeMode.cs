using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Memento
{
    public class OriginatorSafeMode
    {
        private string state;
        public OriginatorSafeMode() { }

        public IMementoSafeMode CreateMemento()
        {
             MementoSafeMode mbox = new MementoSafeMode(this.state);
             return mbox;
        }

        public void RestoreMemento(IMementoSafeMode memento)
        {
            MementoSafeMode mementoSafeMode = (MementoSafeMode)memento;
            this.state = mementoSafeMode.State;
        }

        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        protected class MementoSafeMode : IMementoSafeMode
        {
            private string state;
            /// <summary>
            /// 这里为啥不能private,C#内部类的私有方法外部类也无法访问，
            /// 但是内部类即使定义为public，也只有外部类才能访问。
            /// </summary>
            /// <param name="state"></param>
            public MementoSafeMode(string state)
            {
                this.state = state;
            }

            public string State
            {
                get { return this.state; }
                set { this.state = value; }
            }
        }

    }
}
