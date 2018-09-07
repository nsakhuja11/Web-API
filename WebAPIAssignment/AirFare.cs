using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIAssignment
{
    class AirFare
    {
        public int FinalFare(int basefare)
        {
            Logger log = Logger.GetLogger();
            log.WriteMessage("Calculate Final Fare function called");
            basefare = basefare + (basefare * (40 / 100));
            return basefare;
        }
    }
}
