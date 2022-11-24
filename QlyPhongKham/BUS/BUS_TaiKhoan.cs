using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable timKiemTaiKhoan(string pUser)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(string)));
            dt.Columns.Add(new DataColumn("USERNAME", typeof(string)));
            dt.Columns.Add(new DataColumn("PW", typeof(string)));
            dal_tk.timKiemTaiKhoan(pUser).ForEach(tk =>
            {
                DataRow r = dt.NewRow();
                r["ID"] = tk.ID;
                r["USERNAME"] = tk.USERNAME;
                r["PW"] = tk.PW;
                dt.Rows.Add(r);
            });
            return dt;
        }
        public bool themQuyenChoND(string pID)
        {
            return dal_tk.themQuyenChoND(pID);
        }
    }
}
