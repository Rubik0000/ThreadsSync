using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    public delegate void MessageEvent(object sender, IMessage message);

    public class RandomWriter : ThreadUsing, IWriter
    {
        private static readonly int threadWait = 10;

        private IBuffer _buffer;

        public event MessageEvent OnWrite;

        public RandomWriter(IBuffer buf)
        {
            _buffer = buf;
        }

        /// <summary>
        /// Pushes messages into given buffer
        /// </summary>
        /// <param name="buf"></param>
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

        /// <summary>Override</summary>
        public bool IsWritting() => IsAlive;

        /// <summary>Override</summary>
        public void StartWrite() => Start( () => Write(_buffer) );

        /// <summary>Override</summary>
        public void StopWrite() => Abort();
        
    }
}
