using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    public interface IReader
    {
        void StartRead(int count = 1);

        void StopRead();

        bool IsReading();

        event MessageEvent OnRead;
    }
}
