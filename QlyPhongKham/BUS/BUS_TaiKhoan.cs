using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dal_tk = new DAL_TaiKhoan();

        public bool dangNhap(string tennd, string matkhau)
        {
            return dal_tk.dangNhap(tennd, matkhau);
        }
    }
}
