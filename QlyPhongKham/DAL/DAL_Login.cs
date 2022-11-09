using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Login
    {
        qlyPhongKhamDataContext qlpk = new qlyPhongKhamDataContext();

        public bool dangNhap(string tennd, string matkhau)
        {
            try
            {
                if (qlpk.TAIKHOANs.Where(t => t.USERNAME.Equals(tennd) && t.PW.Equals(matkhau)).Count() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
