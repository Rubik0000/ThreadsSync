using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    /// <summary>
    /// A reader class
    /// </summary>
    public class Reader : ThreadUsing, IReader
    {
        /// <summary>A buffer from which to read</summary>
        private IBuffer _buffer;

        /// <summary>Override</summary>
        public event MessageEvent OnRead;

        public Reader(IBuffer buf)
        {
            _buffer = buf;
        }

        /// <summary>
        /// Takes message from given buffer
        /// </summary>
        /// <param name="buf">From which to read</param>
        /// <param name="count">Count of elements to read</param>
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

        /// <summary>Override</summary>
        public bool IsReading() => IsAlive;

        /// <summary>Override</summary>
        public void StartRead(int count = 1) => 
            Start( () => Read(_buffer, count) );

        /// <summary>Override</summary>
        public void StopRead() => Abort();
        
    }
}
