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

        public void StartRandomCreate(IBuffer buf) =>
            Start(() => RandomCreate(buf));

        public void StopRandomCreate() => Abort();
    }
}
