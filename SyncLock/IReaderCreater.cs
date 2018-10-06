using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    public delegate void ReaderEvent(object sender, IReader reader);

    /// <summary>
    /// An interface to create readers
    /// </summary>
    public interface IReaderCreater
    {
        /// <summary>
        /// Starts to create readers at random time moments
        /// </summary>
        /// <param name="buf">A buffer that is passed to readers</param>
        void StartRandomCreate(IBuffer buf);

        /// <summary>
        /// Stops to create
        /// </summary>
        void StopRandomCreate(bool abortTrackedReaders = false);

        /// <summary>
        /// Occurs when a new reader have been created
        /// </summary>
        event ReaderEvent OnCreateReader;
    }
}
