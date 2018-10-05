using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    class ReaderCreater : ThreadUsing, IReaderCreater
    {
        private static readonly int threadWait = 100;

        public event ReaderEvent OnCreateReader;

        /// <summary>
        /// Create readers at random time moments
        /// </summary>
        /// <param name="buf"></param>
        protected void RandomCreate(IBuffer buf)
        {
            var random = new Random();
            for (; ; )
            {
                if (random.Next(0, 40) == 10)
                    OnCreateReader?.Invoke(this, new Reader(buf));
                
                Thread.Sleep(threadWait);
            }
        }

        /// <summary>Override</summary>
        public void StartRandomCreate(IBuffer buf) =>
            Start(() => RandomCreate(buf));

        /// <summary>Override</summary>
        public void StopRandomCreate() => Abort();
    }
}
