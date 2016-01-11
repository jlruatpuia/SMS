using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace SMS.DAL
{
    class Customers
    {
        OleDbConnection cm = new OleDbConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

        public string CreateCustomer(string CustomerName, string Address, string PhoneNo, string Email, byte[] Photo)
        {
            string msg = null;
            OleDbCommand cmd = new OleDbCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "CreateCustomer",
                Connection = cm,
            };
            cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Photo", Photo);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally { cm.Close(); }
            return msg;
        }
    }
}
