using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    public class ReaderCreater : ThreadUsing, IReaderCreater
    {
        private static readonly int threadWait = 100;

        private IReader[] _readers;

        public event ReaderEvent OnCreateReader;

        public int CountReaders { get; private set; }

        public ReaderCreater(int countRead)
        {
            CountReaders = countRead;
            _readers = new IReader[CountReaders];
        }

        private int GetSpareIndReader()
        {
            for (int i = 0; i < _readers.Length; ++i)
            {
                if (_readers[i] == null || !_readers[i].IsReading())
                    return i;
            }
            return -1;
        }

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
                {
                    int ind = GetSpareIndReader();
                    if (ind != -1)
                    {
                        _readers[ind] = new Reader(buf);
                        OnCreateReader?.Invoke(this, _readers[ind]);
                    }
                }
                
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
