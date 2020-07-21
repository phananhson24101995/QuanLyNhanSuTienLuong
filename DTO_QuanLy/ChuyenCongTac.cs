using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class ChuyenCongTac
    {
        private string maChuyen ;
        public string MaChuyen
        {
            get { return maChuyen; }
            set { maChuyen = value; }
        }

        private string maNV;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        private DateTime ngayChuyen;
        public DateTime NgayChuyen
        {
            get { return ngayChuyen; }
            set { ngayChuyen = value; }
        }

        private string maCVCu;
        public string MaCVCu
        {
            get { return maCVCu; }
            set { maCVCu = value; }
        }

        private string maCVMoi;
        public string MaCVMoi
        {
            get { return maCVMoi; }
            set { maCVMoi = value; }
        }

        private string maPBCu;
        public string MaPBCu
        {
            get { return maPBCu; }
            set { maPBCu = value; }
        }

        private string maPBMoi;
        public string MaPBMoi
        {
            get { return maPBMoi; }
            set { maPBMoi = value; }
        }

        private string maPB;
        public string MaPB
        {
            get { return maPB; }
            set { maPB = value; }
        }
    }
}
