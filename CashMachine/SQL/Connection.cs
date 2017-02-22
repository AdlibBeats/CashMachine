using System;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using CashMachine.Model;

namespace CashMachine.SQL
{
    public class Connection
    {

        public ObservableCollection<Product> GetProducts()
        {
            ObservableCollection<Product> products = new ObservableCollection<Product>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetProducts", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        products.Add
                        (
                            new Product()
                            {
                                ID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                PurchasePrice = reader.GetDouble(2),
                                WholesalePrice = reader.GetDouble(3)
                            });
                    }
                }
                reader.Close();
            }
            return products;
        }
    }
}
