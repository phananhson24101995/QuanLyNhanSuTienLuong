using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class HopDong
    {
        private string maHD;
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        private string tenHD;
        public string TenHD
        {
            get { return tenHD; }
            set { tenHD = value; }
        }

        private string loaiHD;
        public string LoaiHD
        {
            get { return loaiHD; }
            set { loaiHD = value; }
        }

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
