using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    public interface IWriter
    {
        void StartWrite(IBuffer buf);

        void StopWrite();

        bool IsWritting();
    }
}
