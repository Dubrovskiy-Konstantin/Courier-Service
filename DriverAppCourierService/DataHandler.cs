using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriverAppCourierService.Entities;

namespace DriverAppCourierService
{
    static class DataHandler
    {
        public static DataSet SetData(string tableName)
        {
            DataSet dataSet;
            SqlDataAdapter adapter;
            string connectionString = SqlWorkerDriverApp.connectionString;

            string sql = $"SELECT * FROM [dbo].[{tableName}]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                dataSet = new DataSet();

                adapter.Fill(dataSet);
                connection.Close();
            }

            return dataSet;
        }
    }
}
