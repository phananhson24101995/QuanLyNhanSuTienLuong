using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_ChucVu
    {
        DAL_ChucVu dal_ChucVu = new DAL_ChucVu();
        public ChucVu LayThongTinNhanVien(string username)
        {
            return dal_ChucVu.LayThongTinNhanVien(username);
        }
    }
}
