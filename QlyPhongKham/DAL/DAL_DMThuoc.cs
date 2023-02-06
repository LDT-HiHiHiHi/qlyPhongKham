using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_DMThuoc
    {
        qlyPhongKhamDataContext qlpk = new qlyPhongKhamDataContext();
        public List<DMThuoc> getListThuoc()
        {
            return qlpk.DMTHUOCs.Join(qlpk.DONGIA_THUOCs, t => t.MAT, dg => dg.MAT, (t, dg) => new DMThuoc
            {
                MAT = t.MAT,
                TENT = t.TENTHUOC,
                DVT = t.DONVITINH,
                SL = t.SOLUONG,
                HSD = t.HSD,
                DG = dg.GIA,
                NGCN = dg.NGCAPNHAT
            }).ToList();
        }

        public List<DMThuoc> timKiemThuoc(string ten)
        {
            return qlpk.DMTHUOCs.Where(e=>e.TENTHUOC.Contains(ten)).Join(qlpk.DONGIA_THUOCs, t => t.MAT, dg => dg.MAT, (t, dg) => new DMThuoc
            {
                MAT = t.MAT,
                TENT = t.TENTHUOC,
                DVT = t.DONVITINH,
                SL = t.SOLUONG,
                HSD = t.HSD,
                DG = dg.GIA,
                NGCN = dg.NGCAPNHAT
            }).ToList();
        }

        public bool themThuoc(DMTHUOC thuoc, DONGIA_THUOC dg)
        {
            try
            {
                qlpk.DMTHUOCs.InsertOnSubmit(thuoc);
                qlpk.SubmitChanges();
                qlpk.DONGIA_THUOCs.InsertOnSubmit(dg);
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool capNhatThuoc(DMTHUOC thuoc, DONGIA_THUOC dg)
        {
            try
            {
                DMTHUOC a = qlpk.DMTHUOCs.Where(t => t.MAT.Equals(thuoc.MAT)).FirstOrDefault();
                DONGIA_THUOC b = qlpk.DONGIA_THUOCs.Where(e => e.MAT.Equals(thuoc.MAT)).FirstOrDefault();
                a.TENTHUOC = thuoc.TENTHUOC;
                a.HSD = thuoc.HSD;
                a.DONVITINH = thuoc.DONVITINH;
                a.SOLUONG = thuoc.SOLUONG;
                qlpk.SubmitChanges();

                qlpk.DONGIA_THUOCs.DeleteOnSubmit(b);
                qlpk.SubmitChanges();

                qlpk.DONGIA_THUOCs.InsertOnSubmit(dg);
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool xoaThuoc(string mat)
        {
            try
            {
                DMTHUOC a = qlpk.DMTHUOCs.Where(t => t.MAT.Equals(mat)).FirstOrDefault();
                DONGIA_THUOC b = qlpk.DONGIA_THUOCs.Where(e => e.MAT.Equals(mat)).FirstOrDefault();

                qlpk.DONGIA_THUOCs.DeleteOnSubmit(b);
                qlpk.SubmitChanges();

                qlpk.DMTHUOCs.DeleteOnSubmit(a);
                qlpk.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int checkThuoc(string mat)
        {
            return qlpk.CT_TOATHUOCs.Where(t => t.MAT.Equals(mat)).Count();
        }

        public DateTime? getDay(string mat)
        {
            return qlpk.DONGIA_THUOCs.Where(t => t.MAT.Equals(mat)).Select(a => a.NGCAPNHAT).FirstOrDefault();
        }
    } 
}
