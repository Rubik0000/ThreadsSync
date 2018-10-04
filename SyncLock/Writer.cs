using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    public delegate void MessageEvent(object sender, IMessage message);

    class RandomWriter : ThreadUsing, IWriter
    {
        private static readonly int threadWait = 10;

        private IBuffer _buffer;

        public event MessageEvent OnWrite;

        public RandomWriter(IBuffer buf)
        {
            _buffer = buf;
        }

        protected void Write(IBuffer buf)
        {
            var rand = new Random();
            int count = 0;
            for (; ; )
            {
                if (rand.Next(0, 100) == 4)
                {
                    var newMes = new Message("Message " + count++);
                    if (buf.Push(newMes))
                        OnWrite?.Invoke(this, newMes);
                }
                Thread.Sleep(threadWait);
            }
        }

        public bool IsWritting() => IsAlive;

        public void StartWrite() => Start( () => Write(_buffer) );
        
        public void StopWrite() => Abort();
        
    }
}
