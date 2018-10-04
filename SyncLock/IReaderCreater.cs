using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    public delegate void ReaderEvent(object sender, IReader reader);

    interface IReaderCreater
    {
        void StartRandomCreate(IBuffer buf);

        void StopRandomCreate();

        event ReaderEvent OnCreateReader;
    }
}
