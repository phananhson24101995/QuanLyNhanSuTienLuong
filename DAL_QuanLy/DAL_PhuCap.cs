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
    public class DAL_PhuCap:QuanLyKetNoi
    {
        public void XoaPC(string MaPC)
        {
            DAL_PhuCap dal_PhuCap = new DAL_PhuCap();
            dal_PhuCap.Open();
            string deleteString = "XOAPC";
            SqlCommand cmd = new SqlCommand(deleteString, dal_PhuCap.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPC", SqlDbType.Int).Value = MaPC;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_PhuCap.Close();
        }
        public void ThemPC(PhuCap pc)
        {
            DAL_PhuCap dal_PhuCap = new DAL_PhuCap();
            dal_PhuCap.Open();
            string insertString = "insert into PhuCap(MaPC,TenPC,HeSoPC,Ghichu) values(" + pc.MaPC + ",'" + pc.TenPC + "'," + pc.HeSoPC + ","
                + pc.GhiChu+ "')";
            SqlCommand cmd = new SqlCommand(insertString, dal_PhuCap.conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_PhuCap.Close();
        }
        public void CapNhatPC(PhuCap pc)
        {
            DAL_PhuCap dal_PhuCap = new DAL_PhuCap();
            dal_PhuCap.Open();
            string updateString = "SUAPB";
            SqlCommand cmd = new SqlCommand(updateString, dal_PhuCap.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPC", SqlDbType.Text).Value = pc.MaPC;
            cmd.Parameters.Add("@TenPC", SqlDbType.Text).Value = pc.TenPC;
            cmd.Parameters.Add("@HeSoPC", SqlDbType.Float).Value = pc.HeSoPC;
            cmd.Parameters.Add("@GhiChu", SqlDbType.Text).Value = pc.GhiChu;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_PhuCap.Close();
        }
        public int LayMaPC()
        {
            DAL_PhuCap dal_PhuCap = new DAL_PhuCap();
            dal_PhuCap.Open();
            string selectString = "select top 1 MaPC from PhuCap order by MaPC desc";
            SqlCommand cmd = new SqlCommand(selectString, dal_PhuCap.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int Mapc = reader.GetInt32(0);
            reader.Dispose();
            dal_PhuCap.Close();
            return Mapc + 1;
        }
    }
}
