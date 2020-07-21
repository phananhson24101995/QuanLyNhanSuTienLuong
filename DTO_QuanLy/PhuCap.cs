using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class PhuCap
    {
        private string maPC;
        public string MaPC
        {
            get { return maPC; }
            set { maPC = value; }
        }

        private string tenPC;
        public string TenPC
        {
            get { return tenPC; }
            set { tenPC = value; }
        }

        private float heSoPC;
        public float HeSoPC
        {
            get { return heSoPC; }
            set { heSoPC = value; }
        }

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
