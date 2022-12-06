using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataLayer
{
    public class DB_Operations
    {
        private static MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public static int ExcecuteQuery(string MySql)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(MySql, connection);
                connection.Open();
                return command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public static DataSet ExcSelectQuery(String mysql)
        {
            try
            {
                MySqlDataAdapter myda = new MySqlDataAdapter(mysql,connection);
                connection.Open();
                DataSet ds = new DataSet();
                myda.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                connection.Close();
            }
        }
     }
}
