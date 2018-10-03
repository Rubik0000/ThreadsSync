using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    class QueueBufferLock : QueueBuffer
    {
        private object locker = new object();

        public QueueBufferLock(int cap) : base(cap) { }
        
        protected override void Sync(Action syncCode)
        {
            lock (locker)
            {
                syncCode();
            }
        }
    }
}
