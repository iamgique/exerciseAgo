using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ExerciseAgoda.Models
{
    public class ConnectDB
    {

        public SqlConnection conn;

        public bool Open(String Connection = "DefaultConnection")
        {
            conn = new SqlConnection(@WebConfigurationManager.ConnectionStrings[Connection].ToString());
            try
            {
                bool b = true;
                if (conn.State.ToString() != "Open")
                {
                    conn.Open();
                }
                return b;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}