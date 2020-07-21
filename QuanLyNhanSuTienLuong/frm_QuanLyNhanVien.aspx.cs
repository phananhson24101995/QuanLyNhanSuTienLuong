using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO_QuanLy;
using BUS_QuanLy;
using System.Data;
using System.Dynamic;
using Antlr.Runtime;

namespace QuanLyNhanSuTienLuong
{
    public partial class frm_QuanLyNhanVien : System.Web.UI.Page
    {
        string a;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string tk;
                //LoadNV();
                //LoadTKNV(a);
               
                string timkiem = txt_timkiem.Text;
                LoadTKNV(timkiem);
                
            }

        }
        int stt = 1;

        public string get_manv()

        {

            return Convert.ToString(stt++);

        }
        protected void datagrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //Do something here to make it page, baby!
            gvNhanVien.PageIndex = e.NewPageIndex;   //trang hien tai

            int trang_thu = e.NewPageIndex;      //the hien trang thu may

            int so_dong = gvNhanVien.PageSize;       //moi trang co bao nhieu dong

            stt = trang_thu * so_dong + 1;

            //LoadNV();
            string timkiem = txt_timkiem.Text;
            LoadTKNV(timkiem);

        }
        public void LoadNV()
        {
            BUS_NhanVien busNV = new BUS_NhanVien();
            gvNhanVien.DataSourceID = null; // string.Empty can also used
            gvNhanVien.DataSource = busNV.DanhSachNhanVien();
            gvNhanVien.DataBind();
        }
        public void LoadTKNV(string tk)
        {
            BUS_NhanVien busNV = new BUS_NhanVien();
            DataTable dt = new DataTable();
            gvNhanVien.DataSourceID = null; // string.Empty can also used
            if (string.IsNullOrEmpty(tk) || string.IsNullOrWhiteSpace(tk))
            {
                dt = busNV.DanhSachNhanVien();
                if (dt == null)
                {
                    dt = new DataTable();
                }
            }
            else
            {
                dt = busNV.DanhSachTimKiem(tk);
                //if(gvNhanVien.RowCount == null)
                //{

                //}    
            }

            gvNhanVien.DataSource = dt.DefaultView;
            gvNhanVien.DataBind();
        }
        protected void gvNhanVien_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvNhanVien.EditIndex = e.NewEditIndex;
            //LoadNV();
            string timkiem = txt_timkiem.Text;
            LoadTKNV(timkiem);
        }
        protected void GvNhanVien_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvNhanVien.EditIndex = e.NewEditIndex;
            //LoadNV();
            string timkiem = txt_timkiem.Text;
            LoadTKNV(timkiem);
        }
        //protected void gvNhanVien_RowUpdating(object sender, GridViewEditEventArgs e)
        //{
        //    gvNhanVien.EditIndex = e.NewEditIndex;
        //    LoadNV();
        //}
        protected void gvNhanVien_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvNhanVien.EditIndex = -1;
            //LoadNV();
            string timkiem = txt_timkiem.Text;
            LoadTKNV(timkiem);
        }
        protected void gvNhanVien_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //lay thong khach hang can cap nhat
            string timkiem = txt_timkiem.Text;
            string MaNV = gvNhanVien.DataKeys[e.RowIndex].Value.ToString();
            GridViewRow row = gvNhanVien.Rows[e.RowIndex];
            Session["MaNV"] = MaNV;
            TextBox txtHoTen = row.FindControl("txtHoTen") as TextBox;
            string HoTen = txtHoTen.Text.Trim();

            TextBox txtNamSinh = row.FindControl("txtNamSinh") as TextBox;
            DateTime NamSinh = DateTime.Parse(txtNamSinh.Text.Trim());

            //DateTime s1 = System.Convert.ToDateTime(txtNamSinh.Text.Trim());
            //DateTime date = (s1);
            //String NamSinh = date.ToString("yyyy-MM-dd");

            DropDownList ddlGioiTinh = row.FindControl("ddlGioiTinh") as DropDownList;
            bool GioiTinh = Convert.ToBoolean(Convert.ToInt32(ddlGioiTinh.SelectedItem.Value));
            //string GioiTinh = ddlGioiTinh.SelectedItem.Value.ToString();
            //int SoCMND = int.Parse(row.FindControl(txtSoCMND) as TextBox).Text);

            TextBox txtSoCMND = row.FindControl("txtSoCMND") as TextBox;
            int SoCMND = Int32.Parse(txtSoCMND.Text);

            TextBox txtDiaChi = row.FindControl("txtDiaChi") as TextBox;
            string DiaChi = txtDiaChi.Text.Trim();

            TextBox txtSDT = row.FindControl("txtSDT") as TextBox;
            string SDT = txtSDT.Text.Trim();

            TextBox txtEmail = row.FindControl("txtEmail") as TextBox;
            string Email = txtEmail.Text.Trim();

            TextBox txtMaPB = row.FindControl("txtMaPB") as TextBox;
            string MaPB = txtMaPB.Text.Trim();

            TextBox txtMaCV = row.FindControl("txtMaCV") as TextBox;
            string MaCV = txtMaCV.Text.Trim();

            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            nv.HoTen = HoTen;
            nv.DiaChi = DiaChi;
            nv.NamSinh = NamSinh;
            nv.GioiTinh = GioiTinh;
            nv.SoCMND = SoCMND;
            nv.SDT = SDT;
            nv.Email = Email;
            nv.MaPB = MaPB;
            nv.MaCV = MaCV;

            BUS_NhanVien busNV = new BUS_NhanVien();
            busNV.CapNhatThongTinNV(nv);

            gvNhanVien.EditIndex = -1;

            LoadTKNV(timkiem);
            //LoadNV();
            

        }

        protected void gvNhanVien_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string manv = gvNhanVien.DataKeys[e.RowIndex].Value.ToString();
            BUS_NhanVien busNV = new BUS_NhanVien();
            busNV.XoaNhanVien(manv);
            //LoadNV();
            string timkiem = txt_timkiem.Text;
            LoadTKNV(timkiem);
        }

        protected void gvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        protected void btn_timkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txt_timkiem.Text;
            BUS_NhanVien busNV = new BUS_NhanVien();
            busNV.DanhSachTimKiem(timkiem);
            if(busNV.DemTK(timkiem) == 0)
            {
                lbltb.Text = "Không có dữ liệu cần tìm kiếm";
            }    
            gvNhanVien.EditIndex = -1;
            LoadTKNV(timkiem);

              
        }

        protected void gvNhanVien_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            //string manv = gvNhanVien.DataKeys[e.RowIndex].Value.ToString();
            string datakey = gvNhanVien.DataKeys[e.NewSelectedIndex].Value.ToString();
            Session["MaNV"] = datakey;
            //lbltb.Text = datakey.ToString();
            Response.Redirect("ThongTinCTNV.aspx");

        }

        protected void btn_them_Click(object sender, EventArgs e)
        {

        }
    }
}