using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = Logger.GetLogger();
            log.WriteMessage("Entered Main");
            ProductType _type = new ProductType();
            int choice = 1;
            while(choice != 0)
            {
                Console.WriteLine("Enter Type of Storage you want to use");
                Console.WriteLine("1 for File Storage");
                Console.WriteLine("2 for database Storage");
                int storageChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the type of Product (e.g. CarProduct / AirProduct / HotelProduct / ActivityProduct)");
                string desc = Console.ReadLine();
                IProduct prod = _type.GetProductType(desc);
                log.WriteMessage("Entered Main");
                Console.WriteLine("Enter name of Product");
                string name = Console.ReadLine();
                prod.GetTypeOfProduct();
                log.WriteMessage("Entered Main");
                Console.WriteLine("Enter 1 to Save or 2 to Book");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                {
                    prod.Save(name, storageChoice);
                    log.WriteMessage("Entered Main");
                }
                else if (userChoice == 2)
                {
                    prod.Book(name, storageChoice);
                    log.WriteMessage("Entered Main");
                }
                Console.WriteLine("Enter 1 to continue or 0 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
