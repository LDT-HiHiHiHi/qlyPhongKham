using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_QLNND
    {
        private qlyPhongKhamDataContext db = new qlyPhongKhamDataContext();
        DAL_QLTK qltk = new DAL_QLTK();

        public bool addToGr(int pIdQuyen, string pIdTK)
        {
            try
            {
                db.NHOMNGUOIDUNGs.InsertOnSubmit(new NHOMNGUOIDUNG
                {
                    ID_Q = pIdQuyen,
                    ID_TK = pIdTK
                });
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DelToGr(int pIdQuyen, string pIdTK)
        {
            try
            {
                var nnd = db.NHOMNGUOIDUNGs.Where(nd => nd.ID_Q == pIdQuyen && nd.ID_TK == pIdTK).Single();

                //db.NHOMNGUOIDUNGs.deAttach(nnd);
                db.NHOMNGUOIDUNGs.DeleteOnSubmit(nnd);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<QUYEN> getGrs()
        {
            return db.QUYENs.ToList();
        }

        public bool themNhom(string pTenNhom)
        {
            try
            {
                db.QUYENs.InsertOnSubmit(new QUYEN
                {
                    TENQUYEN = pTenNhom
                });
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool xoaNhom(string pTenQuyen)
        {
            try
            {
                var gr = db.QUYENs.Where(g => g.TENQUYEN == pTenQuyen).Single();

                if (qltk.getDSNhomTK(gr.MAQUYEN).Count() > 0)
                {
                    throw new Exception("Còn user trong nhóm.Vui lòng thử lại");
                }

                db.QUYENs.DeleteOnSubmit(gr);
                db.SubmitChanges();
            }
            catch (Exception err)
            {
                throw err;
            }
            return true;
        }

        public bool chinhSua(int pID, string pTenQuyen)
        {
            try
            {
                QUYEN gr = db.QUYENs.Where(g => g.MAQUYEN == pID).Single();
                gr.TENQUYEN = pTenQuyen;

                db.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool isExists(string pTenQuyen)
        {
            if (db.QUYENs.Where(g => g.TENQUYEN == pTenQuyen).Count() != 0)
                return true;

            return false;
        }

    }
}
