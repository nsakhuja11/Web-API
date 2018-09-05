using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet
{
    class HotelProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Hotel";
        }
        public void Save()
        {
            Console.WriteLine("Saving hotel product");
        }
        public void Book()
        {
            Console.WriteLine("Booking hotel product");
        }
    }
}
