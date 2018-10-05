using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    /// <summary>
    /// A reader interface
    /// </summary>
    public interface IReader
    {
        /// <summary>
        /// Starts to get a given number of elements
        /// </summary>
        /// <param name="count"></param>
        void StartRead(int count = 1);

        /// <summary>
        /// Stops to get 
        /// </summary>
        void StopRead();

        /// <summary>
        /// Whether a reader is getting elements
        /// </summary>
        /// <returns>True if it does</returns>
        bool IsReading();

        /// <summary>
        /// An event occurs when a reader have gotten an elements
        /// </summary>
        event MessageEvent OnRead;
    }
}
