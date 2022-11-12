using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_Login
    {
        DAL_Login dal_lg = new DAL_Login();

        public bool dangNhap(string tennd, string matkhau)
        {
            try 
            {
                return dal_lg.dangNhap(tennd, matkhau);
            }
            catch (Exception e)
            {
                throw e; // lỗi cấu hình || server
            }
        }
    }
}
