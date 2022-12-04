using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_ThongTinCaNhan
    {
        DAL_ThongTinCaNhan dal_tt = new DAL_ThongTinCaNhan();
        public THONGTINTAIKHOAN getThongTin(string id)
        {
            return dal_tt.getThongTin(id);
        }

        public int ckThongTin(string id)
        {
            return dal_tt.ckThongTin(id);
        }

        public bool luuThongTin(THONGTINTAIKHOAN tt)
        {
            return dal_tt.luuThongTin(tt);
        }

        public bool capNhatThongTin(THONGTINTAIKHOAN tt)
        {
            return dal_tt.capNhatThongTin(tt);
        }
    }
}
