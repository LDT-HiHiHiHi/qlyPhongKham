using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_QLTK
    {
        qlyPhongKhamDataContext db = new qlyPhongKhamDataContext();
        public List<TaiKhoan> lstNhomNguoiDung(string pUsername)
        {
            return db.TAIKHOANs.Join(
                db.NHOMNGUOIDUNGs,
                tk => tk.ID,
                nnd => nnd.ID_TK,
                (tk, nnd) => new TaiKhoan
                {
                    Username = tk.USERNAME,
                    IdGr = nnd.ID_Q
                }).Where(tk => tk.Username == pUsername).ToList();
        }
        public List<PhanQuyen> lstManHinh(int pIdGr)
        {
            return db.QL_PHANQUYENs.Where(pq => pq.MAQUYEN == pIdGr).Select(pq => new PhanQuyen
            {
                IdGr = pq.MAQUYEN,
                IdMH = pq.ID_MH,
                CoQuyen = pq.COQUYEN
            }).ToList();
        }
        public List<TaiKhoan> getDSNhomTK(int pQuyen)
        {
            return db.NHOMNGUOIDUNGs.Where(nnd => nnd.ID_Q == pQuyen).Select(nnd => new TaiKhoan
            {
                IdTK = nnd.TAIKHOAN.ID,
                Username = nnd.TAIKHOAN.USERNAME
            }).ToList();
        }
        public List<TaiKhoan> getDSTK(int pNhomNguoiDung)
        {
            return db.TAIKHOANs.GroupJoin(
                db.NHOMNGUOIDUNGs,
                tk => tk.ID,
                nnd => nnd.ID_TK,
                (tk, nnd) => new
                {
                    tk,
                    nnd
                }
            ).SelectMany(
                tttk => tttk.nnd.DefaultIfEmpty(),
                (account, groupAccount) => new TaiKhoan
                {
                    IdTK = account.tk.ID,
                    Username = account.tk.USERNAME
                }
            ).Where(tk => !db.NHOMNGUOIDUNGs.Where(nd => nd.ID_Q == pNhomNguoiDung).Any(nd => nd.ID_TK == tk.IdTK) && tk.Username != string.Empty).Distinct().ToList();

        }
    }
}
