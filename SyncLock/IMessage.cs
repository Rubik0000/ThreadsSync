using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    /// <summary>
    /// An interface for "provider-consumer" messages
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Gets a message
        /// </summary>
        /// <returns>A message</returns>
        string GetMessage();
    }
}
