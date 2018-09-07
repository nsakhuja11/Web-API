using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIAssignment
{
    class ActivityFare
    {
        public int FinalFare(int basefare)
        {
            Logger log = Logger.GetLogger();
            log.WriteMessage("Calculate Final Fare function called");
            basefare = basefare + (basefare * (30 / 100));
            return basefare;
        }
    }
}
