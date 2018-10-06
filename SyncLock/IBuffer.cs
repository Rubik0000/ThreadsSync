using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    /// <summary>
    /// Provides an interface for a buffer
    /// </summary>
    public interface IBuffer : IEnumerable<IMessage>
    {
        /// <summary>
        /// Puts a message into a buffer
        /// </summary>
        /// <param name="mes">A message it needs to put</param>
        /// <returns>True if the message was successfuly added</returns>
        bool Push(IMessage mes);

        /// <summary>
        /// Gets a message from a buffer
        /// </summary>
        /// <returns>The message or null if it was not gotten</returns>
        IMessage Pop();

        /// <summary>
        /// Gets a capacity of a buffer
        /// </summary>
        int Capacity { get; }

        /// <summary>
        /// Gets a count of elements in a buffer
        /// </summary>
        int Count { get; }

        event EventHandler OnChange;
    }
}
