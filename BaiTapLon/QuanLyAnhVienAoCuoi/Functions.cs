using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QuanLyAnhVienAoCuoi
{
    class Functions
    {
        public static SqlConnection con;
        public static string conString;

        public static void connect()
        {
            conString  = "Data Source=LAPTOP-NALUFR0D;Initial Catalog=QuanLyAnhVienAoCuoi;Integrated Security=True";
            con = new SqlConnection();
            con.ConnectionString = conString;
            con.Open();
        }

        public static void disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();   	
                con.Dispose();     
                con = null;
            }

        }



        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, Functions.con);
            DataTable table = new DataTable();
            adp.Fill(table);
            return table;

        }

        
        public static string GetFieldValues(string sql)
        {
            string masp = "";
            SqlCommand cmd = new SqlCommand(sql, Functions.con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                masp = reader.GetValue(0).ToString();
            }
            reader.Close();
            return masp;
        }

        public static void Runsql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Functions.con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        

        
    }
}
