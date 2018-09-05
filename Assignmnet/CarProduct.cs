using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet
{
    class CarProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Car";
        }
        public void Save()
        {
            Console.WriteLine("Saving car product");
        }
        public void Book()
        {
            Console.WriteLine("Booking car product");
        }
    }
}
