using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class NhanVien
    {
        private string maNV;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        private string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private DateTime namSinh;
        public DateTime NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private bool gioiTinh;
        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private int soCMND;
        public int SoCMND
        {
            get { return soCMND; }
            set { soCMND = value; }
        }

        private string sDT;
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string maPB;
        public string MaPB
        {
            get { return maPB; }
            set { maPB = value; }
        }

        private string maCV;
        public string MaCV
        {
            get { return maCV; }
            set { maCV = value; }
        }

        private int quyen;
        public int Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        private string hinh;
        public string Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }

        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

    }
}
