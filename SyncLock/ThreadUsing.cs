using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    abstract class ThreadUsing
    {
        private Thread _thread;

        protected bool IsAlive => _thread.IsAlive;

        protected void Start(ThreadStart func)
        {
            _thread = new Thread(func);
            _thread.Start();
        }

        protected void Abort()
        {
            try
            {
                _thread?.Abort();
            }
            finally { }
        }
    }
}
