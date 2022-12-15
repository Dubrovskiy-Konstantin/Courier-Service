using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp
{
    public class Program
    {
        public static void GetTaxes(out string costPerKm, out string costPerMover, out string minCost)
        {
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourierService;Integrated Security=True";
            string connectionString = "Data Source=mssql-99901-0.cloudclusters.net,10105;" +
                  "Initial Catalog=CourierService;" +
                  "User id=Admin;" +
                  "Password=123QWErty;";

            costPerKm = "1.0";
            costPerMover = "0.3";
            minCost = "29.99";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                try
                {
                    command.CommandText = "Select * from [dbo].[Taxes];";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        switch (reader.GetValue(0).ToString())
                        {
                            case "cost_per_km":
                                {
                                    costPerKm = reader.GetValue(1).ToString();
                                    break;
                                }
                            case "cost_per_mover":
                                {
                                    costPerMover = reader.GetValue(1).ToString();
                                    break;
                                }
                            case "min_cost":
                                {
                                    minCost = reader.GetValue(1).ToString();
                                    break;
                                }
                        }
                    }
                    reader.Close();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
