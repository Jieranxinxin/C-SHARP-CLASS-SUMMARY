using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件之EventHandler类
{
    class RingEventArgs:EventArgs
    {
        private int ringKind;
        public int RingKind
        {
            get
            {
                return ringKind;
            }
        }
        public RingEventArgs(int ringKind)
        {
            this.ringKind = ringKind;
        }
    }
}
