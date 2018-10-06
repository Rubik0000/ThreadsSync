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
        static private readonly int bufSize = 20;
        static private readonly int maxPopMes = 5;
        static private readonly int minPopMes = 1;

        static void Main(string[] args)
        {
            var buf = new QueueBufferLock(bufSize);

            // The main writer
            var writer = new RandomWriter(buf);
            writer.OnWrite += (object sender, IMessage mes) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Push: " + mes.GetMessage());
                //Console.ForegroundColor = ConsoleColor.White;
            };
            
            // The main reader creater
            //!!
            var readerCreater = new ReaderCreater();
            var rand = new Random();

            readerCreater.OnCreateReader += (object sender, IReader reader) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("New reader");

                // when a new reader is created
                // it gives an event handler and starts to read
                reader.OnRead += (object sen, IMessage mes) =>
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pop:  " + mes.GetMessage());
                };

                reader.StartRead(rand.Next(minPopMes, maxPopMes));
            };

            Console.WriteLine("One writer pushes data into a buffer\r\n" +
                "A lot of randomly created readers get data form the one\r\n");
            Console.WriteLine("Press 's' to start a simulation\r\n" +
                "Press 'q' to stop the one\r\n");

            // start threads
            PressKey(new char[] { 's', 'S' });

            writer.StartWrite();
            readerCreater.StartRandomCreate(buf);

            // stops threads
            PressKey(new char[] { 'q', 'Q' });

            writer.StopWrite();
            readerCreater.StopRandomCreate(true);
        }

        /// <summary>
        /// Waits until user will press given key
        /// </summary>
        /// <param name="keys">A keys it needs to press</param>
        static private void PressKey(Char[] keys)
        {
            for (; ; )
            {
                var t = Console.ReadKey(true);
                if (keys.Contains(t.KeyChar)) return;
            }
        }
    }
}
