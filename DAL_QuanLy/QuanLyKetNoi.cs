using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAL_QuanLy
{
    public class QuanLyKetNoi
    {
        public SqlConnection conn;
        public QuanLyKetNoi()
        {
            string connString = @"Data Source=DESKTOP-V4O2127\SQLEXPRESS;Initial Catalog=QLNhanSuTienLuong;Integrated Security=True";
            conn = new SqlConnection(connString);
        }
        public void Open()
        {
            conn.Open();

        }
        public void Close()
        {
            conn.Close();
        }
    }
    
}
