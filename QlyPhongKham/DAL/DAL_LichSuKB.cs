using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_LichSuKB
    {
        qlyPhongKhamDataContext qlpk = new qlyPhongKhamDataContext();

        public List<LichSu> getListLS(string mabn)
        {
            return qlpk.LS_KHAMBENHs.Where(t => t.MABN.Equals(mabn) && t.TRANGTHAI == true).Join(qlpk.BENHNHANs, ls => ls.MABN, bn => bn.MABN, (ls, bn) => new LichSu
            {
                MABN = bn.MABN,
                LSKB = ls.MALS,
                TENBN = bn.TENBN,
                STT = (int)ls.STT,
                NGAY = ls.NGKHAM
            }).ToList();
        }

        public string getTenBS(string mals)
        {
            string mabs = qlpk.LS_KHAMBENHs.Where(t => t.MALS.Equals(mals)).Select(a => a.MABS).FirstOrDefault();
            string matk = qlpk.BACSIs.Where(b => b.MABS.Equals(mabs)).Select(c => c.IDTK).FirstOrDefault();
            return qlpk.THONGTINTAIKHOANs.Where(e => e.ID_TAIKHOAN.Equals(matk)).Select(f => f.HOTEN).FirstOrDefault();
        }
        public string getMaTT(string mals)
        {
            return qlpk.TOATHUOCs.Where(t => t.MALS.Equals(mals)).Select(a => a.MATT).FirstOrDefault();
        }
        public string getLS(string macd)
        {
            return qlpk.PHIEUCHIDINHs.Where(t => t.MACD.Equals(macd)).Select(a=>a.MALS).FirstOrDefault();
        }
        public string getLS2(string matt)
        {
            return qlpk.TOATHUOCs.Where(t => t.MATT.Equals(matt)).Select(a => a.MALS).FirstOrDefault();
        }
    }
}
