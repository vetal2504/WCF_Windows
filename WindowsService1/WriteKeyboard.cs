using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsService1
{
    class WriteKeyboard
    {
        private bool write = true;
        public WriteKeyboard()
        {
            //Work();
        }

        public bool Write
        {
            get
            {
                return write;
            }
            set
            {
                write = value;
            }
        }

        public void Work()
        {
            //string path = Directory.GetCurrentDirectory();
            //FileInfo file = new FileInfo("C:\\Windiws\\file.txt");
            using (StreamWriter sw = new StreamWriter(@"C:\Windows\file.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine("\\n");
                sw.Write(Console.ReadLine());
            }
        }
    }
}
