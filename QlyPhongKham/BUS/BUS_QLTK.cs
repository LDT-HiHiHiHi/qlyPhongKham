using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_QLTK
    {
        DAL_QLTK dal_qltk = new DAL_QLTK();

        public List<TaiKhoan> lstNhomNguoiDung(string pUsername)
        {
            return dal_qltk.lstNhomNguoiDung(pUsername);
        }
        public List<PhanQuyen> lstManHinh(int pIdGr)
        {
            return dal_qltk.lstManHinh(pIdGr);
        }
    }
}
