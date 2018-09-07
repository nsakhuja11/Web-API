using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIAssignment
{
    class Database : IRepository
    {
        public void SaveToMemory(string name, bool status, string type, int price)
        {
            Logger log = Logger.GetLogger();
            log.WriteMessage("Save To Database Function Called");
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=Product;User ID=Sa;Password=test123!@#";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into " + type + " values(@Name,@BookingStatus,@Price)", connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@BookingStatus", status);
            command.Parameters.AddWithValue("@Price", price);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
