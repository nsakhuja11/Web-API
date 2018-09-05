using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet
{
    class AirProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Air";
        }
        public void Save()
        {
            Console.WriteLine("Saving air product");
        }
        public void Book()
        {
            Console.WriteLine("Booking air product");
        }
    }
}
