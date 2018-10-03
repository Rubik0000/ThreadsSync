using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    interface IReader
    {
        void StartRead(IBuffer buf, int count);

        void StopRead();

        bool IsReading();

        event MessageEvent OnRead;
    }
}
