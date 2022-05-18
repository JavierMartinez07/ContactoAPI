using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Mantenimientos.Repository
{
    public class BaseRepository
    {

        private static SqlConnection GetConecction() {

            try
            {
                string connString = "Data Source=DESKTOP-TIQ4RNN;Initial Catalog=ContactoApi;Integrated Security=True;";
                var con = new SqlConnection(connString);
                return con;
                
            }
            catch (Exception)
            {

                throw;
            }
        
        }


        protected static List<T> Query<T>(string query, object parametros = null)
        {
            try
            {
                var con = GetConecction();
                con.Open();
                var result = con.Query<T>(query, parametros).AsList<T>();
                con.Close();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
