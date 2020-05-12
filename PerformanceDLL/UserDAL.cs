using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerformanceEntity;

namespace PerformanceDAL
{
    public class UserDAL
    {

        public static SqlCommand CreateCommand()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = null;

            string Constring = "data source=.; database=POCdb; integrated security=SSPI";
            con.ConnectionString = Constring;
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            return cmd;
        }

        public static int AddUser(UserEntity newuser)
        {
            int UsersAdded = 0;
            SqlCommand cmd = CreateCommand();
            cmd.CommandText = "test"; ; ; ; ;
        }

    }
}
