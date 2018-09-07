using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIAssignment
{
    interface IRepository
    {
        void SaveToMemory(string name, bool status, string type, int price);
    }
}
