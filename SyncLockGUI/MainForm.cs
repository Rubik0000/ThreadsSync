using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SyncLock;


namespace SyncLockGUI
{
    public partial class MainForm : Form
    {
        private static readonly int bufSize = 15;
        private static readonly int countReaders = 5;
        private static readonly int showMessage = 2000;
        private static readonly int minCountMes = 1;
        private static readonly int maxCountMes = 4;

        private IBuffer _buffer = new QueueBufferLock(bufSize);
        private IReaderCreater _readerCreater = new ReaderCreater(countReaders);
        private IWriter _writer;
        private TextBox[] _txtBxReaders;
        private Random rand = new Random();

        public MainForm()
        {
            InitializeComponent();
             _writer = new RandomWriter(_buffer);
            _buffer.OnChange += BufferOnChange;
            _writer.OnWrite += WriterOnWrite;
            _readerCreater.OnCreateReader += ReaderCreaterOnCreate;
            _txtBxReaders = new TextBox[] 
            {
                txtBxReader1,
                txtBxReader2,
                txtBxReader3,
                txtBxReader4,
                txtBxReader5
            };
        }

        /// <summary>
        /// Redraws the buffer
        /// </summary>
        private void BufferOnChange(object sender, EventArgs e)
        {
            ActionOnFormComponents(() => txtBxBuf.Clear());
            var strBuf = new StringBuilder(_buffer.Count);
            foreach (var el in _buffer)
            {
                strBuf.Append(el.GetMessage() + "\r\n");
            }            
            ActionOnFormComponents(() => txtBxBuf.Text = strBuf.ToString());            
        }

        /// <summary>
        /// Gets an spare text box on that a reader shows messages
        /// </summary>
        /// <returns>TextBox or null if all are busy</returns>
        private TextBox GetSpareTxtBxReader()
        {
            foreach (var txtBx in _txtBxReaders)
            {
                if (!txtBx.Enabled) return txtBx;
            }
            return null;
        }

        /// <summary>
        /// Event handler on reader creating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="reader">Created reader</param>
        private void ReaderCreaterOnCreate(object sender, IReader reader)
        {
            // find a spare text box
            var txtBx = GetSpareTxtBxReader();
            while (txtBx == null)
            {
                txtBx = GetSpareTxtBxReader();
            }
            // make it enable
            ActionOnFormComponents(() => 
            {
                txtBx.Enabled = true;
                txtBx.Clear();
            });

            // show message on text box
            reader.OnRead += (object s, IMessage mes) =>
            {
                ActionOnFormComponents(() => txtBx.Text += mes.GetMessage() + ", ");
                Thread.Sleep(showMessage);
            };

            // clear text box and make it not enable
            reader.OnEndReading += (object sen, EventArgs e) =>
                ActionOnFormComponents(() =>
                {
                    txtBx.Clear();
                    txtBx.Enabled = false;
                });
            
            // start to read
            reader.StartRead(rand.Next(minCountMes, maxCountMes));
        }

        /// <summary>
        /// Event handler on writting message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="mes">Created message</param>
        void WriterOnWrite(object sender, IMessage mes)
        {
            ActionOnFormComponents(()=> txtxWriter.Text = mes.GetMessage());
            //Thread.Sleep(showMessage);
            //ActionOnFormComponents(() => txtxWriter.Clear());
        }

        /// <summary>
        /// Starts on a button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e) =>
            Start();
        

        /// <summary>
        /// Stops a simulation
        /// </summary>
        private void Stop()
        {
            _writer.StopWrite();
            _readerCreater.StopRandomCreate(true);
        }

        /// <summary>
        /// Starts a simulation
        /// </summary>
        private void Start()
        {
            _writer.StartWrite();
            _readerCreater.StartRandomCreate(_buffer);
        }

        /// <summary>
        /// Provides distinct actions above form's compontents
        /// Actions above components can be done only in form thread
        /// </summary>
        /// <param name="func"></param>
        private void ActionOnFormComponents(Action func) => 
            Invoke(func);
        
        
        /// <summary>
        /// Form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) =>
            Stop();

        /// <summary>
        /// Stops simulation and clears form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
            _buffer.Clear();
            foreach(var txtBxReader in _txtBxReaders)
            {
                txtBxReader.Clear();
            }
            txtBxBuf.Clear();
            txtxWriter.Clear();
        }
    }
}
