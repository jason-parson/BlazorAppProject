using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace DataLibrary
{
    public class DataAccess
    {
        public static List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
        
        {
            using (IDbConnection connection = new MySqlConnection(connectionString)
            { 
              
            }

        }
    }
}
