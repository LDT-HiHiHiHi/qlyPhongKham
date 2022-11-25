using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_KhamBenh
    {
        qlyPhongKhamDataContext qlpk = new qlyPhongKhamDataContext();
        public bool themDangKiKham(LS_KHAMBENH ls)
        {
            try
            {
                qlpk.LS_KHAMBENHs.InsertOnSubmit(ls);
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string getMaBacSi(string pPhong)
        {
            return qlpk.BACSIs.Where(t => t.MAPHONG.Equals(pPhong)).Select(a=>a.MABS).FirstOrDefault();
        }

        public int checkBenhNhanKham(string pMaBN)
        {
            return qlpk.LS_KHAMBENHs.Where(t => t.MABN.Equals(pMaBN) && t.NGKHAM.Equals(DateTime.Today)).Count();
        }
        public int STT(string pMaBS)
        {
            return qlpk.LS_KHAMBENHs.Where(t => t.MABS.Equals(pMaBS) && t.NGKHAM.Equals(DateTime.Today)).Count();
        }
    }
}
