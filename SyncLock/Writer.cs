using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    public delegate void MessageEvent(object sender, IMessage message);

    class Writer : IWriter
    {
        private Thread _thread;

        public event MessageEvent OnWrite;

        public bool IsWritting()
        {
            throw new NotImplementedException();
        }

        public void StartWrite(IBuffer buf)
        {
            _thread = new Thread(() => Write(buf));
            //_thread.IsBackground = true;
            _thread.Start();
            //Console.WriteLine(_thread.ThreadState);
        }

        protected void Write(IBuffer buf)
        {
            var r = new Random();
            int count = 0;
            for (; ; )
            {
                if (r.Next(0, 100) == 4)
                {
                    var newMes = new Message("Message " + count++);
                    buf.Push(newMes);
                    OnWrite?.Invoke(this, newMes);
                }
                Thread.Sleep(10);
            }
        }

        public void StopWrite()
        {
            try
            {
                _thread.Abort();
            }
            finally { }
        }
    }
}
