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

namespace FrmBasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lblThread.Text.ToString());
            ThreadStart thread = new ThreadStart(MyThreadClass.Thread1);
            //tp
            ThreadStart thread2 = new ThreadStart(MyThreadClass.Thread2);


            Thread ThreadA = new Thread(thread);
            Thread ThreadB = new Thread(thread2);
            //tp
            Thread ThreadC = new Thread(thread);
            Thread ThreadD = new Thread(thread2);

            
            ThreadA.Name = "Thread A process ";
            
            ThreadA.Priority = ThreadPriority.Highest;
            
            ThreadB.Name = "Thread B process ";
            
            ThreadB.Priority = ThreadPriority.Normal;

            //tp
            ThreadC.Name = "Thread C process ";
            
            ThreadC.Priority = ThreadPriority.AboveNormal;

            ThreadD.Name = "Thread D process ";
            
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            lblThread.Text = "* end of threading *";
            Console.WriteLine(lblThread.Text.ToString());
            
        }
    }
}
