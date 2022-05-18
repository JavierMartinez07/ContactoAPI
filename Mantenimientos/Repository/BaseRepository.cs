using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Mantenimientos.Repository
{
    public class BaseRepository
    {
        private static SqlConnection connection = null;

        public static void OpenConecction() {

            try
            {
                string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=contactosAPI;Integrated Security=True;";
                using (connection = new SqlConnection(connString))
                {

                    connection.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        public static void CloseConecction() { 
            connection.Close();
        }

        public static List<T> Query<T>(string query, object parametros = null)
        {
            try
            {
                OpenConecction();
                var result = connection.Query<T>(query, parametros).AsList<T>();
                CloseConecction();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
