using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncLock
{
    class Program
    {
        static void Main(string[] args)
        {
            var buf = new QueueBufferLock(15);

            var writer = new Writer();
            writer.OnWrite += (object sender, IMessage mes) =>
            {
                Console.WriteLine("Push: " + mes.GetMessage());
            };
            writer.StartWrite(buf);

            var reader = new Reader();
            reader.OnRead += (object sender, IMessage mes) =>
            {
                Console.WriteLine("Pop:  " + mes.GetMessage());
            };
            /*for (int i = 1; i <= 50; ++i)
            {
                reader.StartRead(buf, i % 2 + 1);
                Thread.Sleep(2000);
            }*/
            for (; ; )
            {
                var t = Console.ReadKey(true);
                
                //Console.ReadLine();
                if (t.KeyChar == 'q' || t.KeyChar == 'Q')
                {
                    writer.StopWrite();
                    return;
                }
            }
            //Console.ReadLine();
        }
    }
}
