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
    public class BUS_PhongBan
    {
        DAL_PhongBan dal_PhongBan = new DAL_PhongBan();
        public PhongBan LayThongTinNhanVien(string username)
        {
            return dal_PhongBan.LayThongTinNhanVien(username);
        }
    }
}
