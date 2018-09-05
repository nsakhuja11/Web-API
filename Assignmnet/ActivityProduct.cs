using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet
{
    class ActivityProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Activity";
        }
        public void Save()
        {
            Console.WriteLine("Saving activity product");
        }
        public void Book()
        {
            Console.WriteLine("Booking activity product");
        }
    }
}
