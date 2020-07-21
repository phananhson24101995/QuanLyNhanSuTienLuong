using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class ChucVu
    {
        private string maCV;
        public string MaCV
        {
            get { return maCV; }
            set { maCV = value; }
        }

        private string tenCV;
        public string TenCV
        {
            get { return tenCV; }
            set { tenCV = value; }
        }

        private string luongCB;
        public string LuongCB
        {
            get { return luongCB; }
            set { luongCB = value; }
        }
    }
}
