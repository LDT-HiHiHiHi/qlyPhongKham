using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_QLBN
    {
        qlyPhongKhamDataContext qlpk = new qlyPhongKhamDataContext();

        public List<PHONG> getListPhong()
        {
            return qlpk.PHONGs.ToList();
        }

        public bool themBenhNhan(BENHNHAN bn)
        {
            try
            {
                qlpk.BENHNHANs.InsertOnSubmit(bn);
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int checkMaBenhNhan(string pID)
        {
            return qlpk.BENHNHANs.Where(bn => bn.MABN.Equals(pID)).Count();
        }

        public List<BENHNHAN> getListBenhNhan()
        {
            return qlpk.BENHNHANs.ToList();
        }

        public BENHNHAN getBenhNhan(string pID)
        {
            return qlpk.BENHNHANs.Where(t => t.MABN.Equals(pID)).FirstOrDefault();
        }

        public bool suaBenhNhan(BENHNHAN bn)
        {
            try
            {
                BENHNHAN a = qlpk.BENHNHANs.Where(t => t.MABN.Equals(bn.MABN)).FirstOrDefault();
                a.GTINH = bn.GTINH;
                a.TENBN = bn.TENBN;
                a.SDT = bn.SDT;
                a.DIACHI = bn.DIACHI;
                a.NGAYSINH = bn.NGAYSINH;
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<BENHNHAN> timKiemBN(string pTen)
        {
            return qlpk.BENHNHANs.Where(t => t.TENBN.Contains(pTen)).ToList();
        }
        public string getMaBS(string mabn)
        {
            string mals = qlpk.LS_KHAMBENHs.Where(t => t.MABN.Equals(mabn) && t.NGKHAM.Equals(DateTime.Today)).Select(a => a.MALS).FirstOrDefault();
            return qlpk.LS_KHAMBENHs.Where(t => t.MALS.Equals(mals)).Select(a => a.MABS).FirstOrDefault();
        }
        public bool suaPhong(LS_KHAMBENH ls)
        {
            try
            {
                string mals = qlpk.LS_KHAMBENHs.Where(t => t.MABN.Equals(ls.MABN) && t.NGKHAM.Equals(DateTime.Today)).Select(a => a.MALS).FirstOrDefault();
                LS_KHAMBENH bn = qlpk.LS_KHAMBENHs.Where(t => t.MALS.Equals(mals)).FirstOrDefault();
                bn.MABS = ls.MABS;
                bn.STT = ls.STT;
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool themBacSi(BACSI bs)
        {
            try
            {
                qlpk.BACSIs.InsertOnSubmit(bs);
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
