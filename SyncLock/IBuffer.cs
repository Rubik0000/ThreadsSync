using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    public interface IBuffer : IEnumerable<IMessage>
    {
        bool Push(IMessage mes);

        IMessage Pop();

        int Capacity { get; }

        int Count { get; }
    }
}
