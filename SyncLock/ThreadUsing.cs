using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    /// <summary>
    /// A class to use multithreading
    /// </summary>
    public abstract class ThreadUsing
    {
        /// <summary>A thread</summary>
        private Thread _thread = null;

        /// <summary>
        /// Whether the current thread is alive
        /// </summary>
        protected bool IsAlive => _thread == null ? false : _thread.IsAlive;

        /// <summary>
        /// Starts a new thread with given function
        /// </summary>
        /// <param name="func"></param>
        protected void Start(ThreadStart func)
        {
            if (IsAlive)
                Abort();
            _thread = new Thread(func);
            _thread.Start();
        }

        /// <summary>
        /// Terminates the current thread
        /// </summary>
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
