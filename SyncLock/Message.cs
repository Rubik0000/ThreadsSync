using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    /// <summary>
    /// Represents a plain text mesage
    /// </summary>
    class Message : IMessage
    {
        /// <summary>A message</summary>
        private string _mes;

        /// <summary>
        /// A constuctor
        /// </summary>
        /// <param name="mes"></param>
        public Message(string mes)
        {
            _mes = mes;
        }

        /// <summary>
        /// Gets the message
        /// </summary>
        /// <returns></returns>
        public string GetMessage() => _mes;
    }
}
