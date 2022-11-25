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
    }
}
