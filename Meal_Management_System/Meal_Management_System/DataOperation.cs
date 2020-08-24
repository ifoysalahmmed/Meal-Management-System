using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Meal_Management_System
{
    public class DataOperation
    {
        string conncetionstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public DataTable getData(string query)
        {
            SqlConnection conn = new SqlConnection(conncetionstring);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int executequery(string query)
        {
            SqlConnection conn = new SqlConnection(conncetionstring);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                cmd.ExecuteNonQuery();
                return 1;
                conn.Close();
            }
            catch (SqlException e)
            {
                return 0;
            }
        }
    }
}