using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet
{
    public class ProductType
    {
        public IProduct GetProductType(string type)
        {
            if (type == "car")
            {
                return new CarProduct();
            }
            else if (type == "air")
            {
                return new AirProduct();
            }
            else if (type == "hotel")
            {
                return new HotelProduct();
            }
            else if (type == "activity")
            {
                return new ActivityProduct();
            }
            else throw new ApplicationException("This type not available");
        }
    }
}
