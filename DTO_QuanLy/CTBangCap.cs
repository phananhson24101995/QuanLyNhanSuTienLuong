using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class CTBangCap
    {
        private string soHieuBC;
        public string SoHieuBC
        {
            get { return soHieuBC; }
            set { soHieuBC = value; }
        }

        private string maNV;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        private string maBC;
        public string MaBC
        {
            get { return maBC; }
            set { maBC = value; }
        }

        private string noiDaoTao;
        public string NoiDaoTao
        {
            get { return noiDaoTao; }
            set { noiDaoTao = value; }
        }

        private string heDaoTao;
        public string HeDaoTao
        {
            get { return heDaoTao; }
            set { heDaoTao = value; }
        }

    }
}
