using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmBasicThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {

            for (int LoopCount = 0; LoopCount <= 2; LoopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread.Name + " = " + LoopCount);

                Thread.Sleep(500);
            }


        }
        
        //tp
        public static void Thread2()
        {

            for (int LoopCount = 0; LoopCount <= 6; LoopCount++)
            {
                Thread thread2 = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread2.Name + " = " + LoopCount);

                Thread.Sleep(1500);
            }


        }
    }
}
