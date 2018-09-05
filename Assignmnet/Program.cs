using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductType _type = new ProductType();
            string desc = Console.ReadLine();
            IProduct prod = _type.GetProductType(desc);
            prod.GetTypeOfProduct();
            prod.Book();
            prod.Save();
        }
    }
}
