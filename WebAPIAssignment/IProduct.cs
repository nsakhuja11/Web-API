using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIAssignment
{
    public interface IProduct
    {
        string GetTypeOfProduct();

        void Save(string name, int choice);

        void Book(string name, int choice);
    }
}
