using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    /// <summary>
    /// A buffer on a queue base
    /// </summary>
    public class QueueBuffer : IBuffer
    {
        /// <summary>A queue</summary>
        private Queue<IMessage> _queue;

        public event EventHandler OnChange;

        /// <summary>The capacity</summary>
        public int Capacity { get; private set; }

        /// <summary>The count if elements</summary>
        public int Count
        {
            get
            {
                int count = 0;
                Sync(() => { count = _queue.Count; } );
                return count;
            }
        }

        /// <summary>
        /// A constructor
        /// </summary>
        /// <param name="cap">A buffer capacity</param>
        public QueueBuffer(int cap)
        {
            _queue = new Queue<IMessage>(cap);
            Capacity = cap;
        }

        /// <summary>
        /// Pops a message without synchronization
        /// </summary>
        /// <returns>A message or null if the queue is empty</returns>
        private IMessage NotSyncPop() =>
            _queue.Count == 0 ? null : _queue.Dequeue();

        /// <summary>
        /// Pushes a message without synchronization
        /// </summary>
        /// <param name="mes">A message</param>
        /// <returns>True is is was added false if the buffer is full</returns>
        private bool NotSyncPush(IMessage mes)
        {
            if (_queue.Count == Capacity) return false;

            _queue.Enqueue(mes);
            return true;
        }

        /// <summary>
        /// Provides a thread synchronization
        /// By default there is no synchronization
        /// </summary>
        /// <param name="syncCode">A code it needs to synch</param>
        protected virtual void Sync(Action syncCode) { }

        /// <summary>
        /// Pops a message with synchronization
        /// </summary>
        /// <returns>A message or null if the queue is empty</returns>
        public IMessage Pop()
        {
            IMessage mes = null;
            Sync(() => mes = NotSyncPop());
            if (mes != null)
                OnChange?.Invoke(this, EventArgs.Empty);
            return mes;
        }

        /// <summary>
        /// Pushes a message with synchronization
        /// </summary>
        /// <param name="mes"></param>
        /// <returns>True is is was added false if the buffer is full</returns>
        public bool Push(IMessage mes)
        {
            bool res = false;
            Sync(() => res = NotSyncPush(mes));
            if (res)
                OnChange?.Invoke(this, EventArgs.Empty);
            return res;
        }

        /// <summary>Override</summary>
        public void Clear() =>        
            Sync(() => _queue.Clear());
        

        /// <summary>
        /// A enumerator
        /// </summary>
        public IEnumerator<IMessage> GetEnumerator()
        {
            foreach(var mes in _queue)
            {
                yield return mes;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
