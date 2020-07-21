using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
        public void GhiThongTinNhanVien(NhanVien nv)
        {
            dal_NhanVien.GhiThongTinNhanVien(nv);
        }
        public int LaTrungTenDangNhap(string MaNV)
        {
            return dal_NhanVien.LaTrungTenDangNhap(MaNV);
        }
        public int LaTrungEmail(string Email)
        {
            return dal_NhanVien.LaTrungEmail(Email);
        }
        public int LaDangNhapThanhCong(string Username, string Password)
        {
            return dal_NhanVien.LaDangNhapThanhCong(Username, Password);
        }
        //public int LayMaNV(string username)
        //{
        //    return dal_NhanVien.LayMaNV(username);
        //}
        public NhanVien LayThongTinNhanVien(string username)
        {
            return dal_NhanVien.LayThongTinNhanVien(username);
        }
        public DataTable DanhSachNhanVien()
        {
            return dal_NhanVien.DanhSachNhanVien();
        }
        public DataTable DanhSachTimKiem(string tk)
        {
            return dal_NhanVien.DanhSachTimKiem(tk);
        }
        public void ThemNhanVien(NhanVien nv)
        {
            dal_NhanVien.ThemNhanVien(nv);
        }
        public void XoaNhanVien(string MaNV)
        {
            dal_NhanVien.XoaNhanVien(MaNV);
        }
        public void CapNhatThongTinNV(NhanVien nv)
        {
            dal_NhanVien.CapNhatThongTinNV(nv);
        }
        public int DemTK(string tk)
        {
            return dal_NhanVien.DemTK(tk);
        }
        //public string taoMaNhanVien()
        //{
        //    dal_NhanVien.taoMaNhanVien();
        //}
        public string Matutang()
        {
            return dal_NhanVien.Matutang();
        }
    }
}
