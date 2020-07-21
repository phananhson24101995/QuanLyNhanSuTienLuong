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
    public class DAL_ChucVu:QuanLyKetNoi
    {
        public void XoaCV(string MaCV)
        {
            DAL_ChucVu dal_ChucVu = new DAL_ChucVu();
            dal_ChucVu.Open();
            string deleteString = "XOACV";
            SqlCommand cmd = new SqlCommand(deleteString, dal_ChucVu.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCV", SqlDbType.Int).Value = MaCV;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_ChucVu.Close();
        }
        public void ThemCV(ChucVu cv)
        {
            DAL_ChucVu dal_ChucVu = new DAL_ChucVu();
            dal_ChucVu.Open();
            string insertString = "insert into ChucVu(MaCV,TenCV,LuongCB) values(" + cv.MaCV + ",'" + cv.TenCV + "'," + cv.LuongCB + "')";
            SqlCommand cmd = new SqlCommand(insertString, dal_ChucVu.conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_ChucVu.Close();
        }
        public void CapNhatCV(ChucVu cv)
        {
            DAL_ChucVu dal_ChucVu = new DAL_ChucVu();
            dal_ChucVu.Open();
            string updateString = "SUAPB";
            SqlCommand cmd = new SqlCommand(updateString, dal_ChucVu.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaCV", SqlDbType.Text).Value = cv.MaCV;
            cmd.Parameters.Add("@TenCV", SqlDbType.Text).Value = cv.TenCV;
            cmd.Parameters.Add("@LuongCB", SqlDbType.Money).Value = cv.LuongCB;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_ChucVu.Close();
        }
        public int LayMaCV()
        {
            DAL_ChucVu dal_ChucVu = new DAL_ChucVu();
            dal_ChucVu.Open();
            string selectString = "select top 1 MaCV from ChucVu order by MaCV desc";
            SqlCommand cmd = new SqlCommand(selectString, dal_ChucVu.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int Mapc = reader.GetInt32(0);
            reader.Dispose();
            dal_ChucVu.Close();
            return Mapc + 1;
        }
        public ChucVu LayThongTinNhanVien(string username)
        {
            DAL_ChucVu dal_ChucVu = new DAL_ChucVu();
            dal_ChucVu.Open();
            string qry = "select NhanVien.HoTen, NhanVien.GioiTinh, NhanVien.DiaChi, NhanVien.NamSinh, NhanVien.SoCMND, NhanVien.SDT, NhanVien.Email, PhongBan.TenPB, ChucVu.TenCV from NhanVien, PhongBan, ChucVu where (NhanVien.MaPB=PhongBan.MaPB) AND (NhanVien.MaCV=ChucVu.MaCV) AND (NhanVien.MaNV = '" + username + "')";
            SqlCommand cmd1 = new SqlCommand(qry, dal_ChucVu.conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            ChucVu cv = new ChucVu();
            if (reader1.HasRows)
            {
                reader1.Read();
                cv.TenCV = (string)reader1["TenCV"];
            }
            reader1.Dispose();
            cmd1.Dispose();
            dal_ChucVu.Close();

            return cv;
        }
    }
}
