using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    /// <summary>
    /// A writer interface
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Starts to write messages
        /// </summary>
        void StartWrite();

        /// <summary>
        /// Stops to write
        /// </summary>
        void StopWrite();

        /// <summary>
        /// Whether a writer is writting message
        /// </summary>
        /// <returns>True is it does</returns>
        bool IsWritting();

        /// <summary>
        /// Occurs when a message is pushed
        /// </summary>
        event MessageEvent OnWrite;
    }
}
