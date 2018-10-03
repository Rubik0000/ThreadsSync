using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    class Message : IMessage
    {
        private string _mes;

        public Message(string mes)
        {
            _mes = mes;
        }

        public string GetMessage() => _mes;
    }
}
