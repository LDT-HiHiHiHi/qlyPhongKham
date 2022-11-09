using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_PhanQuyen
    {
        qlyPhongKhamDataContext db = new qlyPhongKhamDataContext();
        public List<fn_PhanQuyenResult> getPhanQuyens(int pIDNhomNguoiDung)
        {
            return db.fn_PhanQuyen(pIDNhomNguoiDung).ToList();
        }

        public bool luuTT_PQ(QL_PHANQUYEN pq)
        {
            try
            {
                // xem có tồn tại trong bảng phân quyền chưa
                var dbPQ = db.QL_PHANQUYENs.Where(p => p.MAQUYEN == pq.MAQUYEN && p.ID_MH == pq.ID_MH).FirstOrDefault();
                if (dbPQ == null)
                    db.QL_PHANQUYENs.InsertOnSubmit(pq);
                else
                {
                    dbPQ.COQUYEN = pq.COQUYEN;
                }
                db.SubmitChanges();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }
    }
}
