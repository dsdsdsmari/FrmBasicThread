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
            Thread ThreadA = new Thread(thread);
            Thread ThreadB = new Thread(thread);
            ThreadA.Start();
            ThreadA.Name = "Thread A process ";
            ThreadB.Start();
            ThreadB.Name = "Thread B process ";
            ThreadA.Join();
            ThreadB.Join();
            lblThread.Text = "* end of threading *";
            Console.WriteLine(lblThread.Text.ToString());
            
        }
    }
}
