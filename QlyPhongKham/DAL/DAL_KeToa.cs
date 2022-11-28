using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_KeToa
    {
        qlyPhongKhamDataContext qlpk = new qlyPhongKhamDataContext();

        public List<THUOC> getListThuoc()
        {
            return qlpk.DMTHUOCs.Select(t => new THUOC
            {
                MAT = t.MAT,
                TENT = t.TENTHUOC
            }).ToList();
        }

        public List<THUOC> timKiemThuoc(string ten)
        {
            return qlpk.DMTHUOCs.Where(a=>a.TENTHUOC.Contains(ten)) .Select(t => new THUOC
            {
                MAT = t.MAT,
                TENT = t.TENTHUOC
            }).ToList();
        }

        public List<ToaThuoc> getListToaThuoc(string matt)
        {
            return qlpk.CT_TOATHUOCs.Where(t => t.MATT.Equals(matt)).Join(qlpk.DMTHUOCs, ct => ct.MAT, at => at.MAT, (ct, at) => new ToaThuoc
            {
                MATT = ct.MATT,
                TENT = at.TENTHUOC,
                SB = (int)ct.SOBUOI,
                SL = (int)ct.SOLUONGUONG,
                TONG = (int)ct.TONGSOLUONG,
                DONGIA = (double)qlpk.DONGIA_THUOCs.Where(dg => dg.MAT.Equals(ct.MAT)).Select(b => b.GIA).FirstOrDefault()
            }).ToList();
        }

        public string getMaToaThuoc(string mals)
        {
            return qlpk.TOATHUOCs.Where(t => t.MALS.Equals(mals)).Select(a => a.MATT).FirstOrDefault();
        }

        public bool themToaThuoc(string mals,string matt,string mat,int sb, int sl,int tong)
        {
            try
            {
                TOATHUOC tt = new TOATHUOC
                {
                    MATT = matt,
                    MALS = mals,
                    TONGTIENTT = 0,
                    TRANGTHAI = false
                };
                qlpk.TOATHUOCs.InsertOnSubmit(tt);
                qlpk.SubmitChanges();

                CT_TOATHUOC ct = new CT_TOATHUOC
                {
                    MATT = matt,
                    MAT = mat,
                    SOBUOI = sb,
                    SOLUONGUONG = sl,
                    TONGSOLUONG = tong
                };

                qlpk.CT_TOATHUOCs.InsertOnSubmit(ct);
                qlpk.SubmitChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public int checkCTTT(string matt, string mat)
        {
            return qlpk.CT_TOATHUOCs.Where(t => t.MATT.Equals(matt) && t.MAT.Equals(mat)).Count();
        }
        public int checkTT(string mals)
        {
            return qlpk.TOATHUOCs.Where(t=>t.MALS.Equals(mals)).Count();
        }
        public bool themToaThuoc_DaCo(string matt, string mat, int sb, int sl, int tong)
        {
            try
            {
                CT_TOATHUOC ct = new CT_TOATHUOC
                {
                    MATT = matt,
                    MAT = mat,
                    SOBUOI = sb,
                    SOLUONGUONG = sl,
                    TONGSOLUONG = tong
                };

                qlpk.CT_TOATHUOCs.InsertOnSubmit(ct);
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateCT(CT_TOATHUOC tt)
        {
            try
            {
                CT_TOATHUOC ct = qlpk.CT_TOATHUOCs.Where(t => t.MATT.Equals(tt.MATT) && t.MAT.Equals(tt.MAT)).FirstOrDefault();
                ct.SOBUOI = tt.SOBUOI;
                ct.SOLUONGUONG = tt.SOLUONGUONG;
                ct.TONGSOLUONG = tt.TONGSOLUONG;

                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool capNhatThanhTien(string matt)
        {
            try
            {
                double tong = 0;
                if(qlpk.CT_TOATHUOCs.Where(c=>c.MATT.Equals(matt)).Count() > 0)
                {
                    tong = qlpk.CT_TOATHUOCs.Where(t => t.MATT.Equals(matt)).Join(qlpk.DMTHUOCs, ct => ct.MAT, at => at.MAT, (ct, at) => new ToaThuoc
                    {
                        MATT = ct.MATT,
                        TENT = at.TENTHUOC,
                        SB = (int)ct.SOBUOI,
                        SL = (int)ct.SOLUONGUONG,
                        TONG = (int)ct.TONGSOLUONG,
                        DONGIA = (double)qlpk.DONGIA_THUOCs.Where(dg => dg.MAT.Equals(ct.MAT)).Select(b => b.GIA).FirstOrDefault()
                    }).Sum(z => z.DONGIA * z.TONG);
                }    
                
                TOATHUOC tt = qlpk.TOATHUOCs.Where(g => g.MATT.Equals(matt)).FirstOrDefault();
                tt.TONGTIENTT = tong;
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            qlpk.CT_TOATHUOCs.Where(t => t.MATT.Equals(matt)).Join(qlpk.DMTHUOCs, ct => ct.MAT, at => at.MAT, (ct, at) => new ToaThuoc
            {
                MATT = ct.MATT,
                TENT = at.TENTHUOC,
                SB = (int)ct.SOBUOI,
                SL = (int)ct.SOLUONGUONG,
                TONG = (int)ct.TONGSOLUONG,
                DONGIA = (double)qlpk.DONGIA_THUOCs.Where(dg => dg.MAT.Equals(ct.MAT)).Select(b => b.GIA).FirstOrDefault()
            }).ToList();
        }
        
        public bool capNhatSoLuong(string mat,int sl)
        {
            try
            {
                DMTHUOC t = qlpk.DMTHUOCs.Where(a => a.MAT.Equals(mat)).FirstOrDefault();
                t.SOLUONG = t.SOLUONG - sl;
                qlpk.SubmitChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public string getMaT(string tent)
        {
            return qlpk.DMTHUOCs.Where(t => t.TENTHUOC.Equals(tent)).Select(a => a.MAT).FirstOrDefault();
        }
        public int getSoLuong(string matt, string mat)
        {
            return (int)qlpk.CT_TOATHUOCs.Where(t => t.MATT.Equals(matt) && t.MAT.Equals(mat)).Select(a => a.TONGSOLUONG).FirstOrDefault();
        }

        public bool xoaCT(string matt, string mat)
        {
            try
            {
                CT_TOATHUOC ct = qlpk.CT_TOATHUOCs.Where(t => t.MATT.Equals(matt) && t.MAT.Equals(mat)).FirstOrDefault();
                qlpk.CT_TOATHUOCs.DeleteOnSubmit(ct);
                qlpk.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
