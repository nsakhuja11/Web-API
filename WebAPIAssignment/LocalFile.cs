using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebAPIAssignment
{
    class LocalFile : IRepository
{
        private string path = @"C:\Users\nsakhuja\Desktop\savefile.txt";
        public void SaveToMemory(string name, bool status, string type, int price)
        {
            Logger log = Logger.GetLogger();
            log.WriteMessage("Save To File Function Called");
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine("Product Type : " + type);
            sw.WriteLine("Product Name : " + name);
            sw.WriteLine("Booking Status : " + status);
            sw.WriteLine("Price : " + price);
            sw.Flush();
            sw.Close();
        }

        
    }
}
