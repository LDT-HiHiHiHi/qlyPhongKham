using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_ThongTinCaNhan
    {
        qlyPhongKhamDataContext qlpk = new qlyPhongKhamDataContext();

        public THONGTINTAIKHOAN getThongTin(string id)
        {
            return qlpk.THONGTINTAIKHOANs.Where(t => t.ID.Equals(id)).FirstOrDefault();
        }

        public int ckThongTin(string id)
        {
            return qlpk.THONGTINTAIKHOANs.Where(t => t.ID.Equals(id)).Count();
        }

        public bool luuThongTin(THONGTINTAIKHOAN tt)
        {
            try
            {
                qlpk.THONGTINTAIKHOANs.InsertOnSubmit(tt);
                qlpk.SubmitChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool capNhatThongTin(THONGTINTAIKHOAN tt)
        {
            try
            {
                THONGTINTAIKHOAN a = qlpk.THONGTINTAIKHOANs.Where(t => t.ID.Equals(tt.ID)).FirstOrDefault();
                a.HOTEN = tt.HOTEN;
                a.GTINH = tt.GTINH;
                a.DCHI = tt.DCHI;
                a.SDT = tt.SDT;
                a.NGSINH = tt.NGSINH;
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
