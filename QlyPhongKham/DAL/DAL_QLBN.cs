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
    }
}
