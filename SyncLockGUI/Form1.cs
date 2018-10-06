using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyncLock;


namespace SyncLockGUI
{
    public partial class Form1 : Form
    {
        private static int bufSize = 15;
        private static int countReaders = 5;

        private IBuffer _buffer = new QueueBufferLock(bufSize);
        private IReaderCreater _readerCreater = new ReaderCreater(countReaders);
        private IWriter _writer;
        private Action _goCurrThread;

        public Form1()
        {
            InitializeComponent();
             _writer = new RandomWriter(_buffer);
            _buffer.OnChange += BufferOnChange;
            _readerCreater.OnCreateReader += ReaderCreaterOnCreate;
        }

        private void BufferOnChange(object sender, EventArgs e)
        {
            _goCurrThread = ShowBuffer;
            this.Invoke(_goCurrThread);
        }

        private void ReaderCreaterOnCreate(object sender, IReader reader)
        {

        }

        private void ShowBuffer()
        {
            txtBxBuf.Clear();
            var strBuf = new StringBuilder(_buffer.Count);
            foreach (var el in _buffer)
            {
                strBuf.Append(el.GetMessage() + "\r\n");
                //txtBxBuf.Text += el.GetMessage() + "\r\n";
            }
            txtBxBuf.Text = strBuf.ToString();
        }


        void f()
        {
            //var writer = new RandomWriter(_buffer);
            _writer.OnWrite += (object sender, IMessage mes) =>
            {
                this.Invoke(new Action(()=> {
                    txtxWriter.Text = mes.GetMessage();
                }));
            };

            _writer.StartWrite();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            f();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _writer.StartWrite();
            _readerCreater.StartRandomCreate(_buffer);
        }

        private void Stop()
        {
            _writer.StopWrite();
            _readerCreater.StopRandomCreate();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
    }
}
