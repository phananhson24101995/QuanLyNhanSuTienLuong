using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QuanLy;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DAL_BangCap:QuanLyKetNoi
    {
        public void XoaBC(string MaBC)
        {
            DAL_BangCap dal_BangCap = new DAL_BangCap();
            dal_BangCap.Open();
            string deleteString = "XOABC";
            SqlCommand cmd = new SqlCommand(deleteString, dal_BangCap.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBC", SqlDbType.Int).Value = MaBC;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_BangCap.Close();
        }
        public void ThemBC(BangCap bc)
        {
            DAL_BangCap dal_BangCap = new DAL_BangCap();
            dal_BangCap.Open();
            string insertString = "insert into PhuCap(MaBC,TenBC) values(" + bc.MaBC + ",'" + bc.TenBC + "')";
            SqlCommand cmd = new SqlCommand(insertString, dal_BangCap.conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_BangCap.Close();
        }
        public void CapNhatBC(BangCap bc)
        {
            DAL_BangCap dal_BangCap = new DAL_BangCap();
            dal_BangCap.Open();
            string updateString = "SUABC";
            SqlCommand cmd = new SqlCommand(updateString, dal_BangCap.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBC", SqlDbType.Text).Value = bc.MaBC;
            cmd.Parameters.Add("@TenBC", SqlDbType.Text).Value = bc.TenBC;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_BangCap.Close();
        }
        public int LayMaBC()
        {
            DAL_BangCap dal_BangCap = new DAL_BangCap();
            dal_BangCap.Open();
            string selectString = "select top 1 MaBC from BangCap order by MaBC desc";
            SqlCommand cmd = new SqlCommand(selectString, dal_BangCap.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int Mabc = reader.GetInt32(0);
            reader.Dispose();
            dal_BangCap.Close();
            return Mabc + 1;
        }
    }
}
