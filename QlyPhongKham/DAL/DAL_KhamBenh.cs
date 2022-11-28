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
        public List<BenhNhan> getDanhSachBN(string idtk)
        {
            string mabs = qlpk.BACSIs.Where(t => t.IDTK.Equals(idtk)).Select(a => a.MABS).FirstOrDefault();
            return qlpk.LS_KHAMBENHs.Where(t => t.MABS.Equals(mabs) && t.NGKHAM.Equals(DateTime.Today)).Join(qlpk.BENHNHANs, ls => ls.MABN, bn => bn.MABN, (ls, bn) => new BenhNhan
            {
                MABN = bn.MABN,
                LSKB = ls.MALS,
                TENBN = bn.TENBN,
                STT = (int)ls.STT
            }).OrderBy(b=>b.STT).ToList();
        }
        public List<DICHVU> getListDV()
        {
            return qlpk.DICHVUs.ToList();
        }
        public int addSTT(string pMaBS)
        {
            LS_KHAMBENH ls = qlpk.LS_KHAMBENHs.Where(t => t.MABS.Equals(pMaBS) && t.NGKHAM.Equals(DateTime.Today)).OrderByDescending(B => B.STT).FirstOrDefault();
            return (int)ls.STT;
        }

        public bool themChiTietDichVu(string mals, string macd, string madv,string mota)
        {
            try
            {
                PHIEUCHIDINH pcd = new PHIEUCHIDINH
                {
                    MACD = macd,
                    TONGTIENDV = 0,
                    MALS = mals
                };

                qlpk.PHIEUCHIDINHs.InsertOnSubmit(pcd);
                qlpk.SubmitChanges();

                CHITIETCD ct = new CHITIETCD
                {
                    MACD = macd,
                    MADV = madv,
                    HINHANH = string.Empty,
                    KETQUA = string.Empty,
                    MOTA = mota
                };

                qlpk.CHITIETCDs.InsertOnSubmit(ct);
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }
        public List<ChiTietPhieuCD> getListCT(string macd)
        {
            return qlpk.CHITIETCDs.Where(t => t.MACD.Equals(macd)).Join(qlpk.DICHVUs, cd => cd.MADV, dv => dv.MADV, (cd, dv) => new ChiTietPhieuCD
            {
                TENDV = dv.TENDV,
                MACD = cd.MACD,
                MOTA = cd.MOTA,
                KETQUA = cd.KETQUA,
                DONGIA = qlpk.DONGIA_DICHVUs.Where(b => b.MADV.Equals(dv.MADV)).Select(c => c.GIA).FirstOrDefault()
            }).ToList();
        }

        public bool xoaCTCD(string macd, string madv)
        {
            try
            {
                CHITIETCD ct = qlpk.CHITIETCDs.Where(t => t.MACD.Equals(macd) && t.MADV.Equals(madv)).FirstOrDefault();
                qlpk.CHITIETCDs.DeleteOnSubmit(ct);
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int checkPhieuTonTai(string mals)
        {
            return qlpk.PHIEUCHIDINHs.Where(t => t.MALS.Equals(mals)).Count();
        }

        public int checkCTCD(string macd, string madv)
        {
            return qlpk.CHITIETCDs.Where(t => t.MACD.Equals(macd) && t.MADV.Equals(madv)).Count();
        }

        public string getMaCD(string mals)
        {
            return qlpk.PHIEUCHIDINHs.Where(t => t.MALS.Equals(mals)).Select(a => a.MACD).FirstOrDefault();
        }

        public bool updateCD(CHITIETCD cd)
        {
            try
            {
                CHITIETCD ct = qlpk.CHITIETCDs.Where(t => t.MACD.Equals(cd.MACD) && t.MADV.Equals(cd.MADV)).FirstOrDefault();
                ct.MOTA = cd.MOTA;
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool themChiTietDichVu_DaCo(string macd, string madv,string mota)
        {
            try
            {
                CHITIETCD ct = new CHITIETCD
                {
                    MACD = macd,
                    MADV = madv,
                    MOTA = mota,
                    HINHANH = string.Empty,
                    KETQUA = string.Empty
                };

                qlpk.CHITIETCDs.InsertOnSubmit(ct);
                qlpk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string getMaDV(string tendv)
        {
            return qlpk.DICHVUs.Where(t => t.TENDV.Equals(tendv)).Select(a => a.MADV).FirstOrDefault();
        }

        public bool capNhatThanhTien(string macd)
        {
            try
            {
                double? thanhTien = qlpk.CHITIETCDs.Where(t => t.MACD.Equals(macd)).Join(qlpk.DICHVUs, cd => cd.MADV, dv => dv.MADV, (cd, dv) => new ChiTietPhieuCD
                {
                    TENDV = dv.TENDV,
                    MACD = cd.MACD,
                    MOTA = cd.MOTA,
                    KETQUA = cd.KETQUA,
                    DONGIA = qlpk.DONGIA_DICHVUs.Where(b => b.MADV.Equals(dv.MADV)).Select(c => c.GIA).FirstOrDefault()
                }).Sum(c => c.DONGIA);
                if (thanhTien == null)
                {
                    thanhTien = 0;
                }    
                PHIEUCHIDINH pcd = qlpk.PHIEUCHIDINHs.Where(m => m.MACD.Equals(macd)).FirstOrDefault();
                pcd.TONGTIENDV = thanhTien;
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
