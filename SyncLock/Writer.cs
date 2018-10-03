using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    class Writer : IWriter
    {
        private Thread _thread;

        public bool IsWritting()
        {
            throw new NotImplementedException();
        }

        public void StartWrite(IBuffer buf)
        {
            _thread = new Thread(Write);
            //_thread.IsBackground = true;
            _thread.Start();
            Console.WriteLine(_thread.ThreadState);
        }

        protected void Write()
        {
            for (; ; )
            {
                Console.WriteLine("The thread is going");
                Thread.Sleep(1000);
            }
        }

        public void StopWrite()
        {
            _thread.Interrupt();
            Console.WriteLine(_thread.ThreadState);
        }
    }
}
