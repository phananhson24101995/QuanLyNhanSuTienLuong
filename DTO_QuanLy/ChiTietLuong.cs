using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class ChiTietLuong
    {
        private string soHieuLuong;
        public string SoHieuLuong
        {
            get { return soHieuLuong; }
            set { soHieuLuong = value; }
        }

        private DateTime ngayLap;
        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        private DateTime nguoiLap;
        public DateTime NguoiLap
        {
            get { return nguoiLap; }
            set { nguoiLap = value; }
        }

        private string maNV;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        private string maLCB;
        public string MaLCB
        {
            get { return maLCB; }
            set { maLCB = value; }
        }

        private string maPC;
        public string MaPC
        {
            get { return maPC; }
            set { maPC = value; }
        }
    }
}
