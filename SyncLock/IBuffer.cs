using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    public interface IBuffer
    {
        bool Push(IMessage mes);

        bool Pop(IMessage mes);
    }
}
