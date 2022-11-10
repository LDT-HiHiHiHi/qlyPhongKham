using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_QLNND
    {
        DAL_QLNND dal_qlnnd = new DAL_QLNND();

        public bool addToGr(int pIdQuyen, string pIdTK)
        {
            return dal_qlnnd.addToGr(pIdQuyen, pIdTK);
        }

        public bool DelToGr(int pIdGr, string pIdTK)
        {
            return dal_qlnnd.DelToGr(pIdGr, pIdTK);
        }

        public List<QUYEN> getGrs()
        {
            return dal_qlnnd.getGrs();
        }

        public bool isExists(string pTenQuyen)
        {
            return dal_qlnnd.isExists(pTenQuyen);
        }

        public bool chinhSua(int pID, string pTenQuyen)
        {
            return dal_qlnnd.chinhSua(pID, pTenQuyen);
        }

        public bool themNhom(string pTenQuyen)
        {
            return dal_qlnnd.themNhom(pTenQuyen);
        }
        public bool xoaNhom(string pTenQuyen)
        {
            try
            {
                return dal_qlnnd.xoaNhom(pTenQuyen);
            }
            catch (Exception err)
            {

                throw err;
            }
        }
    }
}
