using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_ThucHienDV
    {
        qlyPhongKhamDataContext qlpk = new qlyPhongKhamDataContext();

        public List<ThanhToanDV> getListCD_Today()
        {
            return qlpk.PHIEUCHIDINHs.Where(c=>c.TRANGTHAI == true).Join(qlpk.LS_KHAMBENHs, cd => cd.MALS, ls => ls.MALS, (cd, ls) => new ThanhToanDV
            {
                MACD = cd.MACD,
                TENBN = qlpk.BENHNHANs.Where(t => t.MABN.Equals(ls.MABN)).Select(a => a.TENBN).FirstOrDefault(),
                DAY = ls.NGKHAM
            }).Where(b => b.DAY.Equals(DateTime.Today)).ToList();
        }
        public List<ThanhToanDV> timKiemCD_Today(string macd)
        {
            return qlpk.PHIEUCHIDINHs.Where(c => c.MACD.Contains(macd) && c.TRANGTHAI == true).Join(qlpk.LS_KHAMBENHs, cd => cd.MALS, ls => ls.MALS, (cd, ls) => new ThanhToanDV
            {
                MACD = cd.MACD,
                TENBN = qlpk.BENHNHANs.Where(t => t.MABN.Equals(ls.MABN)).Select(a => a.TENBN).FirstOrDefault(),
                DAY = ls.NGKHAM
            }).Where(b => b.DAY.Equals(DateTime.Today)).ToList();
        }

        public bool updateCTCD(string macd,string madv, string hinhanh,string ketqua)
        {
            try
            {
                CHITIETCD cd = qlpk.CHITIETCDs.Where(t => t.MACD.Equals(macd) && t.MADV.Equals(madv)).FirstOrDefault();
                cd.HINHANH = hinhanh;
                cd.KETQUA = ketqua;
                qlpk.SubmitChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
