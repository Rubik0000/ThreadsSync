﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    abstract class QueueBuffer : IBuffer
    {
        private Queue<IMessage> _queue;

        public int Capacity { get; private set; }

        public int Count
        {
            get
            {
                int count = 0;
                Sync(() => { count = _queue.Count; } );
                return count;
            }
        }

        public QueueBuffer(int cap)
        {
            _queue = new Queue<IMessage>(cap);
            Capacity = cap;
        }

        private IMessage NotSyncPop() =>
            _queue.Count == 0 ? null : _queue.Dequeue();

        private bool NotSyncPush(IMessage mes)
        {
            if (_queue.Count == Capacity) return false;

            _queue.Enqueue(mes);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="syncCode"></param>
        protected abstract void Sync(Action syncCode);

        public IMessage Pop()
        {
            IMessage mes = null;
            Sync(() => mes = NotSyncPop());
            return mes;
        }

        public bool Push(IMessage mes)
        {
            bool res = false;
            Sync(() => res = NotSyncPush(mes));
            return res;
        }

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
