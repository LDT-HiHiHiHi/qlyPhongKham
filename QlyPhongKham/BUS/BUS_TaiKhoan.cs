using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dal_tk = new DAL_TaiKhoan();
        public List<TAIKHOAN> getListTK()
        {
            return dal_tk.getListTK();
        }

        public bool themTaiKhoan(TAIKHOAN tk)
        {
            return dal_tk.themTaiKhoan(tk);
        }
        public int checkTenDangNhap(string pTenDN)
        {
            return dal_tk.checkTenDangNhap(pTenDN);
        }
        public string getTenDangNhap(string pid)
        {
            return dal_tk.getTenDangNhap(pid);
        }
        public bool updateMatKhau(string pUser, string pMatKhau)
        {
            return dal_tk.updateMatKhau(pUser, pMatKhau);
        }
    }
}
