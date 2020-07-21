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
    public class DAL_PhongBan : QuanLyKetNoi
    {
        public void XoaPB(int MaPB)
        {
            DAL_PhongBan dal_PhongBan = new DAL_PhongBan();
            dal_PhongBan.Open();
            string deleteString = "XOAPB";
            SqlCommand cmd = new SqlCommand(deleteString, dal_PhongBan.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPB", SqlDbType.Int).Value = MaPB;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_PhongBan.Close();
        }
        public void ThemPB(PhongBan pb)
        { 
            DAL_PhongBan dal_PhongBan = new DAL_PhongBan();
            dal_PhongBan.Open();
            string insertString = "insert into PhongBan(MaPB,TenPB,MaNV,DiaDiem,SDT) values(" + pb.MaPB + ",'" + pb.TenPB + "'," + pb.MaNV + "," 
                + pb.DiaDiem + "," + pb.SDT + "')";
            SqlCommand cmd = new SqlCommand(insertString, dal_PhongBan.conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_PhongBan.Close();
        }
        public void CapNhatPB(PhongBan pb)
        {
            DAL_PhongBan dal_PhongBan = new DAL_PhongBan();
            dal_PhongBan.Open();
            string updateString = "SUAPB";
            SqlCommand cmd = new SqlCommand(updateString, dal_PhongBan.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPB", SqlDbType.Text).Value = pb.MaPB;
            cmd.Parameters.Add("@TenPB", SqlDbType.Text).Value = pb.TenPB;
            cmd.Parameters.Add("@MaNV", SqlDbType.Text).Value = pb.MaNV;
            cmd.Parameters.Add("@DiaDiem", SqlDbType.Text).Value = pb.DiaDiem;
            cmd.Parameters.Add("@SDT", SqlDbType.Text).Value = pb.SDT;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_PhongBan.Close();
        }
        public int LayMaPB()
        {
            DAL_PhongBan dal_PhongBan = new DAL_PhongBan();
            dal_PhongBan.Open();
            string selectString = "select top 1 MaPB from SanPham order by MaPB desc";
            SqlCommand cmd = new SqlCommand(selectString, dal_PhongBan.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int Mapb = reader.GetInt32(0);
            reader.Dispose();
            dal_PhongBan.Close();
            return Mapb + 1;
        }
        public PhongBan LayThongTinNhanVien(string username)
        {
            DAL_PhongBan dal_PhongBan = new DAL_PhongBan();
            dal_PhongBan.Open();
            string qry = "select NhanVien.HoTen, NhanVien.GioiTinh, NhanVien.DiaChi, NhanVien.NamSinh, NhanVien.SoCMND, NhanVien.SDT, NhanVien.Email, PhongBan.TenPB, ChucVu.TenCV from NhanVien, PhongBan, ChucVu where (NhanVien.MaPB=PhongBan.MaPB) AND (NhanVien.MaCV=ChucVu.MaCV) AND (NhanVien.MaNV = '" + username + "')";
            SqlCommand cmd1 = new SqlCommand(qry, dal_PhongBan.conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            PhongBan pb = new PhongBan();
            if (reader1.HasRows)
            {
                reader1.Read();
                pb.TenPB = (string)reader1["TenPB"];
            }
            reader1.Dispose();
            cmd1.Dispose();
            dal_PhongBan.Close();

            return pb;
        }
    }
}
