using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    class Reader : IReader
    {
        private Thread _thread;

        public event MessageEvent OnRead;

        public bool IsReading()
        {
            throw new NotImplementedException();
        }

        protected void Read(IBuffer buf, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                var mes = buf.Pop();
                if (mes == null) break;

                OnRead?.Invoke(this, mes);
            }
            _thread.Interrupt();
        }

        public void StartRead(IBuffer buf, int count)
        {
            _thread = new Thread(() => Read(buf, count));
            _thread.Start();
        }

        public void StopRead()
        {
            try
            {
                _thread.Abort();
            }
            finally { }
        }
    }
}
