using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class CTHopDong
    {
        private string soHieuHD;
        public string SoHieuHD
        {
            get { return soHieuHD; }
            set { soHieuHD = value; }
        }

        private string maNV;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        private string maHD;
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        private DateTime ngayKy;
        public DateTime NgayKy
        {
            get { return ngayKy; }
            set { ngayKy = value; }
        }

        private DateTime ngayKT;
        public DateTime NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }


    }
}
