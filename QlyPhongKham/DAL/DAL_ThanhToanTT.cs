using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
     public class DAL_ThanhToanTT
    {
        qlyPhongKhamDataContext qlpk = new qlyPhongKhamDataContext();
        public List<ThanhToanTT> getListTT_Today()
        {
            return qlpk.TOATHUOCs.Join(qlpk.LS_KHAMBENHs, cd => cd.MALS, ls => ls.MALS, (cd, ls) => new ThanhToanTT
            {
                MATT = cd.MATT,
                TENBN = qlpk.BENHNHANs.Where(t => t.MABN.Equals(ls.MABN)).Select(a => a.TENBN).FirstOrDefault(),
                DAY = ls.NGKHAM
            }).Where(b => b.DAY.Equals(DateTime.Today)).ToList();
        }
        public List<ThanhToanTT> timKiemTT_Today(string matt)
        {
            return qlpk.TOATHUOCs.Where(c => c.MATT.Contains(matt)).Join(qlpk.LS_KHAMBENHs, cd => cd.MALS, ls => ls.MALS, (cd, ls) => new ThanhToanTT
            {
                MATT = cd.MATT,
                TENBN = qlpk.BENHNHANs.Where(t => t.MABN.Equals(ls.MABN)).Select(a => a.TENBN).FirstOrDefault(),
                DAY = ls.NGKHAM
            }).Where(b => b.DAY.Equals(DateTime.Today)).ToList();
        }

        public List<ChiTietTT> getListCT(string matt)
        {
            return qlpk.CT_TOATHUOCs.Where(t => t.MATT.Equals(matt)).Join(qlpk.DMTHUOCs, cd => cd.MAT, dv => dv.MAT, (cd, dv) => new ChiTietTT
            {
                MATT = cd.MATT,
                TENT = dv.TENTHUOC,
                SOLUONG = (int)cd.TONGSOLUONG,
                DONGIA = qlpk.DONGIA_THUOCs.Where(b => b.MAT.Equals(dv.MAT)).Select(c => c.GIA).FirstOrDefault(),
            }).ToList();
        }
        public int checkCTTT(string matt)
        {
            return qlpk.CT_TOATHUOCs.Where(t => t.MATT.Equals(matt)).Count();
        }
        public bool getTrangThai(string matt)
        {
            return (bool)qlpk.TOATHUOCs.Where(t => t.MATT.Equals(matt)).Select(a => a.TRANGTHAI).FirstOrDefault();
        }
        public double getTongTien(string matt)
        {
            return (double)qlpk.TOATHUOCs.Where(t => t.MATT.Equals(matt)).Select(a => a.TONGTIENTT).FirstOrDefault();
        }
        public bool capNhatTrangThai(string matt)
        {
            try
            {
                TOATHUOC cd = qlpk.TOATHUOCs.Where(t => t.MATT.Equals(matt)).FirstOrDefault();
                cd.TRANGTHAI = true;
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
