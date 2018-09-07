using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebAPIAssignment
{
    class Logger
    {
        private static Logger _logger = null;
        private static readonly object _syncLock = new object();
        private string path = @"C:\Users\nsakhuja\Desktop\logfile.txt";
        private StreamWriter sw;
        private Logger()
        {
            sw = File.AppendText(path);
        }

        public static Logger GetLogger()
        {
            if (_logger == null)
            {
                lock (_syncLock)
                {
                    if (_logger == null)
                    {
                        _logger = new Logger();
                    }
                }
            }
            return _logger;
        }

        public void WriteMessage(string message)
        {
            sw.WriteLine(message);
            sw.Flush();
        }
    }
}
