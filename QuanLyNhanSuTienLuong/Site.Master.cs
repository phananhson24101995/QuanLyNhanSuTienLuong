using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS_QuanLy;
using DTO_QuanLy;

namespace QuanLyNhanSuTienLuong
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            Session.Add("MaNV", "Null");
        }
        public void LoadThongTin()
        {
            if (Session["Username"] != null)
            {
                string username = Session["Username"].ToString();
                BUS_NhanVien bus = new BUS_NhanVien();
                NhanVien nv = new NhanVien();
                nv = bus.LayThongTinNhanVien(username);
                if (nv.Quyen==1)
                {
                    lbl_admin.Text = username;
                }
                else
                {
                    Response.Redirect("home.aspx");
                }

            }
            else
            {
                //Response.Redirect("home.aspx");
            }
        }
    }
}