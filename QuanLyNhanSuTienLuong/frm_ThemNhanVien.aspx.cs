using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO_QuanLy;
using BUS_QuanLy;
using System.Globalization;

namespace QuanLyNhanSuTienLuong
{
    public partial class frm_ThemNhanVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        //tạo mã

        protected void btn_luu_Click(object sender, EventArgs e)
        {
            //string _manv = txt_manv.Text;
            string _hoten = txt_hoten.Text;
            //DateTime _namsinh = DateTime.Parse(txt_namsinh.Text.Trim());
            DateTime _namsinh = new DateTime();
            string strNamStinh = txt_namsinh.Text.Trim();
            if (DateTime.TryParseExact(strNamStinh,
                       "dd/MM/yyyy",
                       new CultureInfo("en-CA"),
                       DateTimeStyles.None,
                out DateTime strNamSinhFormat))
            {
                _namsinh = strNamSinhFormat;
            }
            else
            {
                // thông báo lỗi
            }
            //DateTime _namsinh = DateTime.Parse(txt_namsinh.Text).ToShortDateString();
            bool _gioitinh = Convert.ToBoolean(Convert.ToInt32(ddl_gioitinh.SelectedItem.Selected));
            // valid() kiểm tra thông số đầu vào.
            int _cmnd = Int32.Parse(txt_cmnd.Text);
            string _diachi = txt_diachi.Text;
            string _sdt = txt_sdt.Text;
            string _mail = txt_email.Text;
            string _pb = ddl_phongban.SelectedValue;
            string _cv = ddl_chucvu.SelectedValue;
            int _quyen = 0;
            //if (ddl_gioitinh.SelectedValue == "Nam")
            //{
            //    _gioitinh = 0;
            //}
            //else
            //{
            //    _gioitinh = 0;
            //}
            if (ddl_phongban.SelectedValue == "Khu vực Dragon")
            {
                _pb = "PB1";
            }
            if (ddl_phongban.SelectedValue == "Khu vực Thunder")
            {
                _pb = "PB2";
            }
            if (ddl_phongban.SelectedValue == "Khu vực Rainbow")
            {
                _pb = "PB3";
            }
            if (ddl_phongban.SelectedValue == "Khu vực Sunshine")
            {
                _pb = "PB4";
            }
            if (ddl_phongban.SelectedValue == "Khu vực Tornado")
            {
                _pb = "PB5";
            }
            if (ddl_phongban.SelectedValue == "Khu vực Hydra")
            {
                _pb = "PB7";
            }
            if (ddl_phongban.SelectedValue == "Khu vực Poseidon")
            {
                _pb = "PB8";
            }
            if (ddl_phongban.SelectedValue == "Nhóm Arrow")
            {
                _pb = "PB6";
            }
            if (ddl_phongban.SelectedValue == "Nhóm ME-Dự án")
            {
                _pb = "PB9";
            }
            if (ddl_phongban.SelectedValue == "Phòng hành chính")
            {
                _pb = "PB10";
            }
            if (ddl_phongban.SelectedValue == "Phòng ban tổng")
            {
                _pb = "PB11";
            }
            if (ddl_phongban.SelectedValue == "Phòng kế toán")
            {
                _pb = "PB12";
            }
            //chức vụ
            if (ddl_chucvu.SelectedValue == "Nhân Viên")
            {
                _cv = "CV-NV";
                _quyen = 4;
            }
            if (ddl_chucvu.SelectedValue == "Quản Lý Bán Hàng")
            {
                _cv = "CV-QL";
                _quyen = 3;
            }
            if (ddl_chucvu.SelectedValue == "Quản lý nhân viên")
            {
                _cv = "CV-QLNV";
                _quyen = 1;
            }
            if (ddl_chucvu.SelectedValue == "Giám Đốc")
            {
                _cv = "CV-GD";
                _quyen = 2;
            }
            if (ddl_chucvu.SelectedValue == "Kế Toán")
            {
                _cv = "CV-KT";
                _quyen = 4;
            }

            //Image _hinh = ;

            BUS_NhanVien busNV = new BUS_NhanVien();
            string _manv;
            _manv = busNV.Matutang();
            NhanVien nv = new NhanVien();
            nv.MaNV = _manv;
            nv.HoTen = _hoten;
            nv.DiaChi = _diachi;
            nv.NamSinh = _namsinh;
            nv.GioiTinh = _gioitinh;
            nv.SoCMND = _cmnd;
            nv.SDT = _sdt;
            nv.Email = _mail;
            nv.MaPB = _pb;
            nv.MaCV = _cv;
            nv.Hinh = null;
            nv.MatKhau = "1234";
            nv.Quyen = _quyen;
            //busNV.ThemNhanVienn(nv);
            busNV.ThemNhanVien(nv);

            Label1.Text = "thêm thành công'"+_manv+"'";
            
        }
    }
}