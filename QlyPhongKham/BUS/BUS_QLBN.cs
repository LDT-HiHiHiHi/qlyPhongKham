using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_QLBN
    {
        DAL_QLBN dal_qlbn = new DAL_QLBN();
        public List<PHONG> getListPhong()
        {
            return dal_qlbn.getListPhong();
        }
        public bool themBenhNhan(BENHNHAN bn)
        {
            return dal_qlbn.themBenhNhan(bn);
        }
        public int checkMaBenhNhan(string pID)
        {
            return dal_qlbn.checkMaBenhNhan(pID);
        }
        public List<BENHNHAN> getListBenhNhan()
        {
            return dal_qlbn.getListBenhNhan();
        }
        public BENHNHAN getBenhNhan(string pID)
        {
            return dal_qlbn.getBenhNhan(pID);
        }
        public bool suaBenhNhan(BENHNHAN bn)
        {
            return dal_qlbn.suaBenhNhan(bn);
        }
        public DataTable timKiemBN(string pTen)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MABN", typeof(string)));
            dt.Columns.Add(new DataColumn("TENBN", typeof(string)));
            dt.Columns.Add(new DataColumn("NGAYSINH", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("GTINH", typeof(string)));
            dt.Columns.Add(new DataColumn("SDT", typeof(string)));
            dt.Columns.Add(new DataColumn("DIACHI", typeof(string)));
            dal_qlbn.timKiemBN(pTen).ForEach(tk =>
            {
                DataRow r = dt.NewRow();
                r["MABN"] = tk.MABN;
                r["TENBN"] = tk.TENBN;
                r["NGAYSINH"] = tk.NGAYSINH;
                r["GTINH"] = tk.GTINH;
                r["SDT"] = tk.SDT;
                r["DIACHI"] = tk.DIACHI;
                dt.Rows.Add(r);
            });
            return dt;
        }
        public bool suaPhong(LS_KHAMBENH ls)
        {
            return dal_qlbn.suaPhong(ls);
        }
        public string getMaBSCu(string mabn)
        {
            return dal_qlbn.getMaBS(mabn);
        }
        public bool themBacSi(BACSI bs)
        {
            return dal_qlbn.themBacSi(bs);
        }

    }
}
