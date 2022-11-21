using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_TaiKhoan
    {
        qlyPhongKhamDataContext db = new qlyPhongKhamDataContext();

        public List<TAIKHOAN> getListTK()
        {
            return db.TAIKHOANs.ToList();
        }

        public bool themTaiKhoan(TAIKHOAN tk)
        {
            try
            {
                db.TAIKHOANs.InsertOnSubmit(tk);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int checkTenDangNhap(string pTenDN)
        {
            return db.TAIKHOANs.Where(tk => tk.USERNAME.Equals(pTenDN)).Count();
        }
    }
}
