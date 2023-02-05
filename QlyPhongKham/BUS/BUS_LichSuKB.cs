using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_LichSuKB
    {
        DAL_LichSuKB dal_ls = new DAL_LichSuKB();
        public List<LichSu> getListLS(string mabn)
        {
            return dal_ls.getListLS(mabn);
        }
        public string getTenBS(string mals)
        {
            return dal_ls.getTenBS(mals);
        }
        public string getMaTT(string mals)
        {
            return dal_ls.getMaTT(mals);
        }
        public string getLS(string macd)
        {
            return dal_ls.getLS(macd);
        }
        public string getLS2(string matt)
        {
            return dal_ls.getLS2(matt);
        }
    }
}
