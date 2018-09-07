using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIAssignment
{
    class HotelProduct : IProduct
    {
        bool bookingStatus = false;
        int fare = 100;

        public string GetTypeOfProduct()
        {
            Logger log = Logger.GetLogger();
            log.WriteMessage("GetTypeOfProduct function called");
            return "Hotel";
        }
        public void Save(string name, int choice)
        {
            HotelFare obj = new HotelFare();
            fare = obj.FinalFare(fare);
            Logger log = Logger.GetLogger();
            log.WriteMessage("Save function called");
            Console.WriteLine("Saving hotel product");
            if (choice == 1)
            {
                LocalFile file = new LocalFile();
                file.SaveToMemory(name, bookingStatus, "HotelProduct", fare);
            }
            else if (choice == 2)
            {
                Database database = new Database();
                database.SaveToMemory(name, bookingStatus, "HotelProduct", fare);
            }
        }
        public void Book(string name, int choice)
        {
            HotelFare obj = new HotelFare();
            fare = obj.FinalFare(fare);
            Logger log = Logger.GetLogger();
            log.WriteMessage("Book function called");
            Console.WriteLine("Booking hotel product");
            bookingStatus = true;
            if (choice == 1)
            {
                LocalFile file = new LocalFile();
                file.SaveToMemory(name, bookingStatus, "HotelProduct", fare);
            }
            else if (choice == 2)
            {
                Database database = new Database();
                database.SaveToMemory(name, bookingStatus, "HotelProduct", fare);
            }
        }
    }
}
