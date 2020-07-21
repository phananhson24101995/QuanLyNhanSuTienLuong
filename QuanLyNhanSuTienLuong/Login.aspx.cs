using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS_QuanLy;
using DTO_QuanLy;
using ShopQuanAo;

namespace QuanLyNhanSuTienLuong
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("TrangChu.aspx");
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtTendangnhap.Text.Trim();
            string password = txtMatkhau.Text.Trim();
            string mahoa = MaHoa.EncryptString(password, "03DHTH1_CTTeam");

            BUS_NhanVien bus = new BUS_NhanVien();

            int flag = bus.LaDangNhapThanhCong(username, mahoa);

            if (KiemTraKiTuNhap(username) == false)
            {
                lbl_tb.Text = "Thông tin đăng nhập không chính xác !<br />Vui lòng nhập lại.";
                return;
            }

            if (flag == 0)
            {
                Session["Username"] = username;
                Response.Redirect("TrangChu.aspx");
            }
            else
            {
                if (flag == 1)
                {
                    Session["Username"] = username;
                    Response.Redirect("QuanLy.aspx");

                }
                else
                {
                    lbl_tb.Text = "Thông tin đăng nhập không chính xác !<br />Vui lòng nhập lại.";
                }
            }
        }
        #region chuỗi kiểm tra
        string chuoiDungKiemTra = "1234567890_QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
        #endregion

        #region hàm kiểm tra nhập kí tự đặc biệt vào textbox TenDangNhap
        private bool KiemTraKiTuNhap(string chuoiCanKiemTra)
        {
            foreach (char kitu in chuoiCanKiemTra)
            {
                bool dung = false;
                foreach (char kitu2 in chuoiDungKiemTra)
                {
                    if (kitu == kitu2)
                    {
                        dung = true;
                    }
                }
                if (dung == false)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion
    }
}