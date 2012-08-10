using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Memento
{
    public class CareTakerSafeMode
    {
        private IMementoSafeMode memento;
        public IMementoSafeMode RetriveMemento()
        {
            return this.memento;
        }
        public void SaveMemento(IMementoSafeMode memento)
        {
            this.memento = memento;
        }
    }
}
