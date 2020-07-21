using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyNhanSuTienLuong
{
    public partial class ThongTinCTNV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
        public void LoadThongTin()
        {
            string manv = Session["MaNV"].ToString();
            lbl_ma.Text = manv.ToString();
            BUS_NhanVien busNV = new BUS_NhanVien();
            NhanVien nv = new NhanVien();
            nv = busNV.LayThongTinNhanVien(manv);

            BUS_PhongBan busPB = new BUS_PhongBan();
            PhongBan pb = new PhongBan();
            pb = busPB.LayThongTinNhanVien(manv);

            BUS_ChucVu busCV = new BUS_ChucVu();
            ChucVu cv = new ChucVu();
            cv = busCV.LayThongTinNhanVien(manv);

            txt_hoten.Text = nv.HoTen.ToString();
            txt_diachi.Text = nv.DiaChi.ToString();
            txt_cmnd.Text = nv.SoCMND.ToString();
            txt_sdt.Text = nv.SDT.ToString();
            txt_mail.Text = nv.Email.ToString();
            txt_namsinh.Text = nv.NamSinh.ToString();
            //txt_pb.Text = pb.TenPB.ToString();

            if(nv.GioiTinh.ToString()=="False")
            {
                txt_gt.Text = "Nam";
                //img_anh.ImageUrl = "~/images/avata_nam.png";
            }    
            else
            {
                txt_gt.Text = "Nữ";
                //img_anh.ImageUrl = "~/images/avata_nu.png";
            }
            txt_pb.Text = pb.TenPB.ToString();
            txt_cv.Text = cv.TenCV.ToString();
            if (nv.Hinh == null)
            {
                if (nv.GioiTinh.ToString() == "False")
                {
                    img_anh.ImageUrl = "~/images/AnhNV/avata_nam.png";
                }
                else
                {
                    img_anh.ImageUrl = "~/images/AnhNV/avata_nu.png";
                }
            }
            else
            {
                img_anh.ImageUrl = nv.Hinh;
            }
        }

        protected void lbtn_quaylai_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void btn_Sua_Click(object sender, EventArgs e)
        {
            txt_hoten.ReadOnly = false;
            //txt_gt.ReadOnly = false;
            txt_diachi.ReadOnly = false;
            txt_namsinh.ReadOnly = false;
            txt_mail.ReadOnly = false;
            txt_cmnd.ReadOnly = false;
            txt_sdt.ReadOnly = false;
            txt_pb.ReadOnly = false;
            txt_cv.ReadOnly = false;
            LoadThongTin();
        }
    }
}