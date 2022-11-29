using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_ThanhToanDV
    {
        qlyPhongKhamDataContext qlpk = new qlyPhongKhamDataContext();

        public List<ThanhToanDV> getListCD()
        {
            return qlpk.PHIEUCHIDINHs.Join(qlpk.LS_KHAMBENHs, cd => cd.MALS, ls => ls.MALS, (cd, ls) => new ThanhToanDV
            {
                MACD = cd.MACD,
                TENBN = qlpk.BENHNHANs.Where(t => t.MABN.Equals(ls.MABN)).Select(a => a.TENBN).FirstOrDefault(),
                DAY = ls.NGKHAM
            }).ToList();
        }

        public List<ThanhToanDV> getListCD_Today()
        {
            return qlpk.PHIEUCHIDINHs.Join(qlpk.LS_KHAMBENHs, cd => cd.MALS, ls => ls.MALS, (cd, ls) => new ThanhToanDV
            {
                MACD = cd.MACD,
                TENBN = qlpk.BENHNHANs.Where(t => t.MABN.Equals(ls.MABN)).Select(a => a.TENBN).FirstOrDefault(),
                DAY = ls.NGKHAM
            }).Where(b=>b.DAY.Equals(DateTime.Today)).ToList();
        }

        public List<ThanhToanDV> timKiemCD(string macd)
        {
            return qlpk.PHIEUCHIDINHs.Where(c=>c.MACD.Contains(macd)).Join(qlpk.LS_KHAMBENHs, cd => cd.MALS, ls => ls.MALS, (cd, ls) => new ThanhToanDV
            {
                MACD = cd.MACD,
                TENBN = qlpk.BENHNHANs.Where(t => t.MABN.Equals(ls.MABN)).Select(a => a.TENBN).FirstOrDefault(),
                DAY = ls.NGKHAM
            }).ToList();
        }
        public List<ThanhToanDV> timKiemCD_Today(string macd)
        {
            return qlpk.PHIEUCHIDINHs.Where(c => c.MACD.Contains(macd)).Join(qlpk.LS_KHAMBENHs, cd => cd.MALS, ls => ls.MALS, (cd, ls) => new ThanhToanDV
            {
                MACD = cd.MACD,
                TENBN = qlpk.BENHNHANs.Where(t => t.MABN.Equals(ls.MABN)).Select(a => a.TENBN).FirstOrDefault(),
                DAY = ls.NGKHAM
            }).Where(b => b.DAY.Equals(DateTime.Today)).ToList();
        }

        public int checkCTCD(string macd)
        {
            return qlpk.CHITIETCDs.Where(t => t.MACD.Equals(macd)).Count();
        }

        public double getTongTien(string macd)
        {
            return (double)qlpk.PHIEUCHIDINHs.Where(t => t.MACD.Equals(macd)).Select(a => a.TONGTIENDV).FirstOrDefault();
        }

        public bool capNhatTrangThai(string macd)
        {
            try
            {
                PHIEUCHIDINH cd = qlpk.PHIEUCHIDINHs.Where(t => t.MACD.Equals(macd)).FirstOrDefault();
                cd.TRANGTHAI = true;
                qlpk.SubmitChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool getTrangThai(string macd)
        {
            return (bool)qlpk.PHIEUCHIDINHs.Where(t => t.MACD.Equals(macd)).Select(a => a.TRANGTHAI).FirstOrDefault();
        }
    }
}
