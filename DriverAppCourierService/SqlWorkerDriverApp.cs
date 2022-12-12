using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DriverAppCourierService.Entities;

namespace DriverAppCourierService
{
    static class SqlWorkerDriverApp
    {
        public readonly static string connectionString = @"Data Source=DANILA; Initial Catalog=CourierService; Integrated Security=True;";
        delegate List<List<object>> DBOperation(params string[] operations);
        private static DBOperation operation = delegate (string[] operations)
        {
            var result = new List<List<object>>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    if (operations != null)
                    {
                        foreach (var operation in operations)
                        {
                            SqlCommand cmd = new SqlCommand(operation, connection);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var row = new List<object>();
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        row.Add(reader.GetValue(i));
                                    }
                                    result.Add(row);
                                }
                            }
                        }
                    }
                }
                finally { }
                connection.Close();
            }
            return result;
        };

        public static List<Accounts> GetAccounts()
        {
            var table = operation($@"SELECT * FROM [dbo].[Accounts]");
            var list = new List<Accounts>();
            for (int row = 0; row < table.Count; row++)
            {
                list.Add(new Accounts()
                {
                    Id = (int)table[row][0],
                    Email = (string)table[row][1],
                    Password = (string)table[row][2],
                    IdDriver = (int)table[row][3]
                });
            }
            return list;
        }

        public static void AddAccount(string email, string password, int id)
        {
            operation($@"INSERT INTO [dbo].[Accounts] VALUES ('{email}', '{password}', {id})");
        }

        public static List<Adresses> GetAdresses()
        {
            var table = operation($@"SELECT * FROM [dbo].[Adresses]");
            var adressesList = new List<Adresses>();
            for (int row = 0; row < table.Count; row++)
            {
                adressesList.Add(new Adresses()
                {
                    Id = (int)table[row][0],
                    Address = (string)table[row][1],
                });
            }
            return adressesList;
        }

        public static List<Archive> GetArchive()
        {
            var table = operation($@"SELECT * FROM [dbo].[Archive]");
            var list = new List<Archive>();
            for (int row = 0; row < table.Count; row++)
            {
                list.Add(new Archive()
                {
                    Id = (int)table[row][0],
                    DriverName = (string)table[row][1],
                    CarNumber = (string)table[row][2],
                    OrderPoints = (string)table[row][3],
                });
            }
            return list;
        }

        public static List<Cars> GetCars()
        {
            var table = operation($@"SELECT * FROM [dbo].[Cars]");
            var list = new List<Cars>();
            for (int row = 0; row < table.Count; row++)
            {
                list.Add(new Cars()
                {
                    Id = (int)table[row][0],
                    Mark = (string)table[row][1],
                    RegistryNumber = (string)table[row][2],
                    IssueYear = (int)table[row][3],
                    Mileage = (double)table[row][4],
                    LastMaintenance = (string)table[row][5],
                    IsFree = (bool)table[row][6],
                });
            }
            return list;
        }

        public static void AddCar(string mark, string registryNumber, int issueYear, double mileage, string lastMaintenance)
        {
            operation($@"INSERT INTO [dbo].[Cars] VALUES ('{mark}', '{registryNumber}', {issueYear}, {mileage}, '{lastMaintenance}', 1)");
        }

        public static List<Details> GetDetails()
        {
            var table = operation($@"SELECT * FROM [dbo].[Details]");
            var list = new List<Details>();
            for (int row = 0; row < table.Count; row++)
            {
                list.Add(new Details()
                {
                    Id = (int)table[row][0],
                    OrderNumber = (int)table[row][1],
                    IdPointFrom = (int)table[row][2],
                    IdPointTo = (int)table[row][3],
                    Unit = (string)table[row][4],
                    UnitDescription = (string)table[row][5],
                    UnitAmount = (int)table[row][6],
                });
            }
            return list;
        }

        public static List<Drivers> GetDrivers()
        {
            var table = operation($@"SELECT * FROM [dbo].[Drivers]");
            var list = new List<Drivers>();
            for (int row = 0; row < table.Count; row++)
            {
                list.Add(new Drivers()
                {
                    Id = (int)table[row][0],
                    Name = (string)table[row][1],
                    Phone = (string)table[row][2],
                    CountOfOrder = (int)table[row][3],
                });
            }
            return list;
        }

        public static void AddDriver(string name, string phone)
        {
            operation($@"INSERT INTO [dbo].[Drivers] VALUES ('{name}', '{phone}', 0)");
        }

        public static List<Log> GetLog()
        {
            var table = operation($@"SELECT * FROM [dbo].[Log]");
            var list = new List<Log>();
            for (int row = 0; row < table.Count; row++)
            {
                list.Add(new Log()
                {
                    Id = (int)table[row][0],
                    OrderNumber = (int)table[row][1],
                    EndDate = (string)table[row][2],
                    ArchiveId = (int)table[row][3],
                    Income = (int)table[row][4],
                });
            }
            return list;
        }

        public static List<Movers> GetMovers()
        {
            var table = operation($@"SELECT * FROM [dbo].[Movers]");
            var list = new List<Movers>();
            for (int row = 0; row < table.Count; row++)
            {
                list.Add(new Movers()
                {
                    Id = (int)table[row][0],
                    IdOrder = (int?)table[row][1],
                    Name = (string)table[row][2],
                    Phone = (string)table[row][3],
                });
            }
            return list;
        }

        public static void AddMover(string name, string phone)
        {
            operation($@"INSERT INTO [dbo].[Movers] VALUES (NULL, '{name}', '{phone}')");
        }

        public static List<Nodes> GetNodes()
        {
            var table = operation($@"SELECT * FROM [dbo].[Nodes]");
            var list = new List<Nodes>();
            for (int row = 0; row < table.Count; row++)
            {
                list.Add(new Nodes()
                {
                    Id = (int)table[row][0],
                    IdOrder = (int)table[row][1],
                    IdCar = (int)table[row][2],
                    IdMover = (int)table[row][3],
                    IdDriver = (int)table[row][4],
                });
            }
            return list;
        }

        public static List<Orders> GetOrders()
        {
            var table = operation($@"SELECT * FROM [dbo].[Orders]");
            var list = new List<Orders>();
            for (int row = 0; row < table.Count; row++)
            {
                list.Add(new Orders()
                {
                    Id = (int)table[row][0],
                    OrderNumber = (int)table[row][1],
                    TotalDistance = (float)table[row][2],
                    Cost = (float)table[row][3],
                    Express = (bool)table[row][4],
                    Status = (int)table[row][5],
                    ClientName = (string)table[row][6],
                    ClientPhone = (string)table[row][7],
                    Date = (string)table[row][8],
                });
            }
            return list;
        }

        public static List<Taxes> GetTaxes()
        {
            var table = operation($@"SELECT * FROM [dbo].[Taxes]");
            var list = new List<Taxes>();
            for (int row = 0; row < table.Count; row++)
            {
                list.Add(new Taxes()
                {
                    Name = (string)table[row][0],
                    Value = (string)table[row][1],
                });
            }
            return list;
        }
    }
}
