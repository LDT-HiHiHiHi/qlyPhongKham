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

        public string getTenDangNhap(string pid)
        {
            return db.TAIKHOANs.Where(tk => tk.ID == pid).Select(t => t.USERNAME).FirstOrDefault();
        }

        public bool updateMatKhau(string pUser,string pMatKhau)
        {
            try
            {
                TAIKHOAN tk = db.TAIKHOANs.Where(t => t.USERNAME == pUser).FirstOrDefault();
                tk.PW = pMatKhau;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<TAIKHOAN> timKiemTaiKhoan(string pUser)
        {
            return db.TAIKHOANs.Where(t => t.USERNAME.Contains(pUser)).ToList();
        }

        public string getIDTK(string pUser)
        {
            return db.TAIKHOANs.Where(t => t.USERNAME.Equals(pUser)).Select(a => a.ID).FirstOrDefault();
        }

        public int checkGroupUser(string pID)
        {
            return db.NHOMNGUOIDUNGs.Where(t => t.ID_TK.Equals(pID)).Count();
        }
        public bool themQuyenChoND(string pID)
        {
            try
            {
                int idgr = db.QUYENs.Where(t => t.TENQUYEN.Equals("USER")).Select(p=>p.MAQUYEN).FirstOrDefault();
                NHOMNGUOIDUNG nnd = new NHOMNGUOIDUNG
                {
                    ID_Q = idgr,
                    ID_TK = pID
                };
                db.NHOMNGUOIDUNGs.InsertOnSubmit(nnd);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
