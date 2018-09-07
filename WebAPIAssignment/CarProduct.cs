using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIAssignment
{
    class CarProduct : IProduct
    {
        bool bookingStatus = false;
        int fare = 100;

        public string GetTypeOfProduct()
        {
            Logger log = Logger.GetLogger();
            log.WriteMessage("GetTypeOfProduct function called");
            return "Car";
        }
        public void Save(string name, int choice)
        {
            CarFare obj = new CarFare();
            fare = obj.FinalFare(fare);
            Logger log = Logger.GetLogger();
            log.WriteMessage("Save function called");
            Console.WriteLine("Saving car product");
            if (choice == 1)
            {
                LocalFile file = new LocalFile();
                file.SaveToMemory(name, bookingStatus,"CarProduct",fare);
            }
            else if (choice == 2)
            {
                Database database = new Database();
                database.SaveToMemory(name, bookingStatus, "CarProduct", fare);
            }
        }
        public void Book(string name, int choice)
        {
            CarFare obj = new CarFare();
            fare = obj.FinalFare(fare);
            Logger log = Logger.GetLogger();
            log.WriteMessage("Book function called");
            Console.WriteLine("Booking car product");
            bookingStatus = true;
            if (choice == 1)
            {
                LocalFile file = new LocalFile();
                file.SaveToMemory(name, bookingStatus, "CarProduct", fare);
            }
            else if (choice == 2)
            {
                Database database = new Database();
                database.SaveToMemory(name, bookingStatus, "CarProduct", fare);
            }
        }
    }
}
