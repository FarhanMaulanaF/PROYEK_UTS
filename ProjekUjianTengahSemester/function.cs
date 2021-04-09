using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekUjianTengahSemester
{
    class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString= "data source = DESKTOP-L9BBJ4N\\SQLEXPRESS;database = LatihanDatabase; integrated security = True";
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Processed Succesfully.","Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
