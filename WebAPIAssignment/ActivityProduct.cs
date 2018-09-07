using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIAssignment
{
    class ActivityProduct : IProduct
    {
        bool bookingStatus = false;
        int fare = 100;

        public string GetTypeOfProduct()
        {
            Logger log = Logger.GetLogger();
            log.WriteMessage("GetTypeOfProduct function called");
            return "Activity";
        }
        public void Save(string name, int choice)
        {
            ActivityFare obj = new ActivityFare();
            fare = obj.FinalFare(fare);
            Logger log = Logger.GetLogger();
            log.WriteMessage("Save function called");
            Console.WriteLine("Saving avtivity product");
            if (choice == 1)
            {
                LocalFile file = new LocalFile();
                file.SaveToMemory(name, bookingStatus, "ActivityProduct", fare);
            }
            else if (choice == 2)
            {
                Database database = new Database();
                database.SaveToMemory(name, bookingStatus, "ActivityProduct", fare);
            }
        }
        public void Book(string name, int choice)
        {
            ActivityFare obj = new ActivityFare();
            fare = obj.FinalFare(fare);
            Logger log = Logger.GetLogger();
            log.WriteMessage("Book function called");
            Console.WriteLine("Booking activity product");
            bookingStatus = true;
            if (choice == 1)
            {
                LocalFile file = new LocalFile();
                file.SaveToMemory(name, bookingStatus, "ActivityProduct", fare);
            }
            else if (choice == 2)
            {
                Database database = new Database();
                database.SaveToMemory(name, bookingStatus, "ActivityProduct", fare);
            }
        }
    }
}
