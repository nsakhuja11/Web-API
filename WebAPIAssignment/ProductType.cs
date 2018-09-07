using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIAssignment
{
    public class ProductType
    {
        public IProduct GetProductType(string type)
        {
            Logger log = Logger.GetLogger();
            log.WriteMessage("Entered ProductType");
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var ptype = assembly.GetTypes().FirstOrDefault(x => x.Name == type);
            log.WriteMessage("Instance of "+type+" type is created");
            return (IProduct)Activator.CreateInstance(ptype);
        }
    }
}
