using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QuanLy;
using System.Data.SqlClient;
using System.Collections;

namespace DAL_QuanLy
{
    public class DAL_NhanVien : QuanLyKetNoi
    {
        public void GhiThongTinNhanVien(NhanVien nv)
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            string mahoa = MaHoa.EncryptString(nv.MatKhau, "03DHTH1_CTTeam");
            string insertString = "insert into NhanVien(MaNV,HoTen,NamSinh,DiaChi,GioiTinh,SoCMND,SDT,Email,MaPB,MaCV,Quyen,Hinh,MatKhau) values('" + nv.MaNV + "',N'" + nv.HoTen + "','" + nv.NamSinh + "',N" + nv.DiaChi + ",'" + nv.SoCMND + "','" + nv.SDT + "','" + nv.Email + "','" + nv.MaPB + "','" + nv.MaCV + "','" + nv.Quyen + "','" + nv.Hinh + "','" + mahoa + "' )";
            SqlCommand cmd = new SqlCommand(insertString, dal_NhanVien.conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_NhanVien.Close();

        }
        public int LaTrungTenDangNhap(string MaNV)
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            string selectString = "SELECT * FROM NhanVien WHERE MaNV = '" + MaNV + "'";
            SqlCommand cmd = new SqlCommand(selectString, dal_NhanVien.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return 1;
            }
            return 0;
        }
        public int LaTrungEmail(string Email)
        {
            int flag = 0;
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            string selectString = "SELECT * FROM NhanVien WHERE Email = '" + Email + "'";
            SqlCommand cmd = new SqlCommand(selectString, dal_NhanVien.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                flag = 1;
            }
            cmd.Dispose();
            reader.Dispose();
            dal_NhanVien.Close();
            return flag;
        }
        public int LaDangNhapThanhCong(string Username, string Password)
        {
            int flag = -1;
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            string selectString = "SELECT * FROM NhanVien WHERE MaNV = '" + Username + "' AND MatKhau ='" + Password + "'";
            SqlCommand cmd = new SqlCommand(selectString, dal_NhanVien.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                bool isAdmin = reader.GetBoolean(8);
                if (isAdmin == true)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }
            cmd.Dispose();
            reader.Dispose();
            dal_NhanVien.Close();
            return flag;
        }
        public void LayNV(string username)
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            string selectString = "SELECT MaNV FROM NhanVien WHERE NhanVien = '" + username + "'";
            SqlCommand cmd = new SqlCommand(selectString, dal_NhanVien.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    reader.Read();
            //    int manv = int.Parse(reader.GetValue(0).ToString());
            //    cmd.Dispose();
            //    reader.Dispose();
            //    dal_NhanVien.Close();
            //    return manv;
            //}
            //else
            //{
            //    cmd.Dispose();
            //    reader.Dispose();
            //    dal_NhanVien.Close();
            //    return -1;
            //}
        }
        public NhanVien LayThongTinNhanVien(string username)
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            string qry = "select NhanVien.HoTen, NhanVien.GioiTinh, NhanVien.DiaChi, NhanVien.NamSinh, NhanVien.SoCMND, NhanVien.SDT, NhanVien.Email, PhongBan.TenPB, ChucVu.TenCV, NhanVien.Hinh from NhanVien, PhongBan, ChucVu where (NhanVien.MaPB=PhongBan.MaPB) AND (NhanVien.MaCV=ChucVu.MaCV) AND (NhanVien.MaNV = '" + username + "')";
            SqlCommand cmd1 = new SqlCommand(qry, dal_NhanVien.conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            NhanVien nv = new NhanVien();
            if (reader1.HasRows)
            {
                reader1.Read();
                nv.HoTen = (string)reader1["HoTen"];
                nv.NamSinh = (DateTime)reader1["NamSinh"];
                nv.DiaChi = (string)reader1["DiaChi"];
                nv.GioiTinh = (bool)reader1["GioiTinh"];
                nv.SoCMND = (int)reader1["SoCMND"];
                nv.SDT = (string)reader1["SDT"];
                nv.Email = (string)reader1["Email"];
            }
            reader1.Dispose();
            cmd1.Dispose();
            dal_NhanVien.Close();
            
            return nv;
        }
        public DataTable DanhSachNhanVien()
        {
            DataTable ds = new DataTable();
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            string selectString = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(selectString, dal_NhanVien.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);
            dal_NhanVien.Close();
            return ds;
        }
        public DataTable DanhSachTimKiem(string tk)
        {
            DataTable ds = new DataTable();
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            string selectString = "select * from NhanVien where MaNV like '%" + tk + "%' or HoTen like N'%" + tk + "%' or SDT like '%" + tk + "%' ";
            SqlCommand cmd = new SqlCommand(selectString, dal_NhanVien.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);
            dal_NhanVien.Close();
            return ds;
        }
        public int DemTK(string tk)
        {
            int flag = 0;
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            string dem = "select count(*) from NhanVien where MaNV like '%" + tk + "%' or HoTen like N'%" + tk + "%' or SDT like '%" + tk + "%' ";
            SqlCommand cmd = new SqlCommand(dem, dal_NhanVien.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            flag = reader.GetInt32(0);
            reader.Dispose();
            dal_NhanVien.Close();
            return flag;
        }
        public void ThemNhanVien(NhanVien nv)
        {


            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
           // nv.MaNV = taoMaNhanVien();
            //string mahoa = MaHoa.EncryptString(nv.MatKhau, "03DHTH1_CTTeam");
            string insertString = "insert into NhanVien(MaNV,HoTen,NamSinh,DiaChi,GioiTinh,SoCMND,SDT,Email,MaPB,MaCV,Quyen,MatKhau) " +
                "values(@MaNV,@HoTen,@NamSinh,@DiaChi, @GioiTinh ,@SoCMND,@SDT,@Email,@MaPB,@MaCV,@Quyen,@MatKhau)";
            SqlCommand cmd = new SqlCommand(insertString, dal_NhanVien.conn);
            cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = nv.MaNV;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTen;
            cmd.Parameters.Add("@NamSinh", SqlDbType.Date).Value = nv.NamSinh;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = nv.GioiTinh;
            cmd.Parameters.Add("@SoCMND", SqlDbType.Int).Value = nv.SoCMND;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nv.SDT;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = nv.Email;
            cmd.Parameters.Add("@MaPB", SqlDbType.Char).Value = nv.MaPB;
            cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = nv.MaCV;
            cmd.Parameters.Add("@Quyen", SqlDbType.Int).Value = nv.Quyen;
            //cmd.Parameters.Add("@Hinh", SqlDbType.Image).Value = nv.Hinh;
            cmd.Parameters.Add("@MatKhau", SqlDbType.Char).Value = nv.MatKhau;
            cmd.ExecuteReader();
            cmd.Dispose();
            dal_NhanVien.Close();

        }
        public void XoaNhanVien(string MaNV)
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            //cmd.CommandText = "DELETE FROM excludes WHERE MaNV = @MaNV";
            //cmd.Parameters.AddWithValue("@MaNV", MaNV);
            string deleteString = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(deleteString, dal_NhanVien.conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = MaNV;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dal_NhanVien.Close();
        }
        public void CapNhatThongTinNV(NhanVien nv)
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();

            //string updateString = "Update NhanVien set HoTen = N'"+nv.HoTen+"',NamSinh = '" + nv.NamSinh + "' ,DiaChi= N'" + nv.DiaChi +
            //    "', GioiTinh = '" + nv.GioiTinh + "',SoCMND = '" + nv.SoCMND + "',SDT= '" + nv.SDT + "', Email= '" + nv.Email + "',MaPB='" + nv.MaPB +
            //    "',MaCV = '" + nv.MaCV + "' where MaNV = '"+nv.MaNV+"'";
            //SqlCommand cmd = new SqlCommand(updateString, dal_NhanVien.conn);
            string updateString = "UPDATE NhanVien SET HoTen = @HoTen, NamSinh= @NamSinh, DiaChi= @DiaChi, " +
                "GioiTinh= @GioiTinh, SoCMND= @SoCMND, SDT= @SDT, Email= @Email, MaPB= @MaPB, MaCV= @MaCV WHERE MaNV= @MaNV";
            SqlCommand cmd = new SqlCommand(updateString, dal_NhanVien.conn);
            cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = nv.MaNV;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTen;
            cmd.Parameters.Add("@NamSinh", SqlDbType.Date).Value = nv.NamSinh;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = nv.GioiTinh;
            cmd.Parameters.Add("@SoCMND", SqlDbType.Int).Value = nv.SoCMND;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nv.SDT;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = nv.Email;
            cmd.Parameters.Add("@MaPB", SqlDbType.Char).Value = nv.MaPB;
            cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = nv.MaCV;
            cmd.ExecuteReader();
            cmd.Dispose();
            dal_NhanVien.Close();
        }

        // c30-[0001 - 9999]
        string a;
        public string taoMaNhanVien()
        {
            bool isFinish = false;
            string MaNV = "";
            do
            {
                DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
                dal_NhanVien.Open();
                // select count(*) From NhanVien
                string dem = "select count(*) from NhanVien";
                SqlCommand cmd = new SqlCommand(dem, dal_NhanVien.conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int SoNhanVien = 0;
                reader.Read();
                SoNhanVien = int.Parse(reader.GetValue(0).ToString());
                reader.Dispose();
                // Tạo quy tắc.
                string maTangDan = "";
                int soLuong0 = 4 - SoNhanVien.ToString().Length;
                for (int i = 0; i < soLuong0; i++)
                {
                    maTangDan += "0";
                }
                maTangDan += SoNhanVien.ToString();
                MaNV = "C30-" + maTangDan;

                // Select count(*) From NhanVien Where MaNV = "+MaNV+"
                string dem1 = "select count(*) NhanVien where MaNV =@MaNV";
                SqlCommand cmd1 = new SqlCommand(dem1, dal_NhanVien.conn);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = MaNV;
                int isTonTai = 0;
                reader1.Read();
                isTonTai = int.Parse(reader1.GetValue(0).ToString());
                reader1.Dispose();
                //isTonTai = dem1;
                if (isTonTai > 0)
                {
                    isFinish = false;
                }
                else
                {
                    isFinish = true;
                }
                cmd1.ExecuteReader();
                cmd1.Dispose();
                cmd.ExecuteReader();
                cmd.Dispose();
                dal_NhanVien.Close();
            } while (!isFinish);
           
            return MaNV;
        }
        public string Matutang()
        {
            string s = "C30-";
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            dal_NhanVien.Open();
            string ma = "select top 1 MaNV from NhanVien ORDER BY MaNV DESC";
            
            SqlCommand cmd = new SqlCommand(ma, dal_NhanVien.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string chuoi = (string)reader["MaNV"];
                chuoi = chuoi.Substring(4,4);
                //string chuoi1 = chuoi;
                int kt = Convert.ToInt32(chuoi);
                int k = kt + 1;
                if (k < 10)
                    s = s + "000";
                else if (k < 100)
                    s = s + "00";
                else if (k < 1000)
                    s = s + "0";
                s = s + k.ToString();
                //manv = Convert.ToString((t + “0001”));
            }

            return s;
        }
    }
}
