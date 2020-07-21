using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class PhongBan
    {
        private string maPB;
        public string MaPB
        {
            get { return maPB; }
            set { maPB = value; }
        }

        private string tenPB;
        public string TenPB
        {
            get { return tenPB; }
            set { tenPB = value; }
        }

        private string maNV;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        private string diaDiem;
        public string DiaDiem
        {
            get { return diaDiem; }
            set { diaDiem = value; }
        }

        private string sDT;
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
    }
}
