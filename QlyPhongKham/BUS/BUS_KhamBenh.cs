using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_KhamBenh
    {
        DAL_KhamBenh dal_kb = new DAL_KhamBenh();
        public bool themDangKiKham(LS_KHAMBENH ls)
        {
            return dal_kb.themDangKiKham(ls);
        }
        public string getMaBacSi(string pPhong)
        {
            return dal_kb.getMaBacSi(pPhong);
        }
        public int checkBenhNhanKham(string pMaBN)
        {
            return dal_kb.checkBenhNhanKham(pMaBN);
        }
        public int STT(string pMaBS)
        {
            return dal_kb.STT(pMaBS);
        }
        public List<BenhNhan> getDanhSachBN(string idtk)
        {
            return dal_kb.getDanhSachBN(idtk);
        }
        public List<DICHVU> getListDV()
        {
            return dal_kb.getListDV();
        }
        public int addSTT(string pMaBS)
        {
            return dal_kb.addSTT(pMaBS);
        }
        public bool themChiTietDichVu(string mals, string macd, string madv,string mota)
        {
            return dal_kb.themChiTietDichVu(mals, macd, madv,mota);
        }
        public List<ChiTietPhieuCD> getListCT(string macd)
        {
            return dal_kb.getListCT(macd);
        }
        public bool xoaCTCD(string macd, string madv)
        {
            return dal_kb.xoaCTCD(macd, madv);
        }
        public int checkPhieuTonTai(string mals)
        {
            return dal_kb.checkPhieuTonTai(mals);
        }
        public string getMaCD(string mals)
        {
            return dal_kb.getMaCD(mals);
        }
        public bool updateCD(CHITIETCD cd)
        {
            return dal_kb.updateCD(cd);
        }
        public bool themChiTietDichVu_DaCo(string macd, string madv, string mota)
        {
            return dal_kb.themChiTietDichVu_DaCo(macd, madv, mota);
        }
        public int checkCTCD(string macd, string madv)
        {
            return dal_kb.checkCTCD(macd, madv);
        }
        public string getMaDV(string tendv)
        {
            return dal_kb.getMaDV(tendv);
        }
        public bool capNhatThanhTien(string macd)
        {
            return dal_kb.capNhatThanhTien(macd);
        }
        public bool? getTrangThaiBN(string mals)
        {
            return dal_kb.getTrangThaiBN(mals);
        }
        public bool hoanThanhLichSu(string mals, string chandoan)
        {
            return dal_kb.hoanThanhLichSu(mals, chandoan);
        }
        public string getChanDoan(string mals)
        {
            return dal_kb.getChanDoan(mals);
        }
    }
}
