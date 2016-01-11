using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace SMS.DAL
{
    public class Categories
    {
        OleDbConnection cm = new OleDbConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

        public Categories()
        {

        }

        public struct Category
        {
            public int CategoryID;
            public string CategoryName;
            public string Description;
        }

        public DataTable GetAllCategories()
        {
            OleDbCommand cmd = new OleDbCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "GetAllCategories",
                Connection = cm
            };
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public string CreateCategory(string CategoryName, string Description)
        {
            string msg = null;
            OleDbCommand cmd = new OleDbCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "CreateCategory",
                Connection = cm,
            };
            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
            cmd.Parameters.AddWithValue("@Description", Description);
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

        public string UpdateCategory(string CategoryName, string Description, int ID)
        {
            string msg = null;
            OleDbCommand cmd = new OleDbCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "UpdateCategory",
                Connection = cm,
            };
            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@ID", ID);
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
