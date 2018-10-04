using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    class Reader : ThreadUsing, IReader
    {
        private IBuffer _buffer;

        public event MessageEvent OnRead;

        public Reader(IBuffer buf)
        {
            _buffer = buf;
        }

        protected void Read(IBuffer buf, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                var mes = buf.Pop();
                if (mes == null) break;

                OnRead?.Invoke(this, mes);
            }
            StopRead();
        }

        public bool IsReading() => IsAlive;

        public void StartRead(int count = 1) => 
            Start( () => Read(_buffer, count) );
        
        public void StopRead() => Abort();
        
    }
}
