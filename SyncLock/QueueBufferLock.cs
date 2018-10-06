using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    /// <summary>
    /// A queue with a critical section (lock) synchronization
    /// </summary>
    public class QueueBufferLock : QueueBuffer
    {
        /// <summary>A locker</summary>
        private object locker = new object();

        public QueueBufferLock(int cap) : base(cap) { }

        /// <summary>
        /// Synchs with "lock"
        /// </summary>
        /// <param name="syncCode">A code it needs to synch</param>
        protected override void Sync(Action syncCode)
        {
            lock (locker)
            {
                syncCode();
            }
        }
    }
}
