using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncLock
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new Writer();
            writer.StartWrite(null);
            Console.ReadLine();
            writer.StopWrite();
        }
    }
}
