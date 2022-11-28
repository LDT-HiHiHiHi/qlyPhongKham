using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_KeToa
    {
        DAL_KeToa dal_kt = new DAL_KeToa();
        public List<THUOC> getListThuoc()
        {
            return dal_kt.getListThuoc();
        }

        public DataTable timKiemThuoc(string ten)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MAT", typeof(string)));
            dt.Columns.Add(new DataColumn("TENT", typeof(string)));
            dal_kt.timKiemThuoc(ten).ForEach(tk =>
            {
                DataRow r = dt.NewRow();
                r["MAT"] = tk.MAT;
                r["TENT"] = tk.TENT;
                dt.Rows.Add(r);
            });
            return dt;
        }

        public List<ToaThuoc> getListToaThuoc(string matt)
        {
            return dal_kt.getListToaThuoc(matt);
        }

        public string getMaToaThuoc(string mals)
        {
            return dal_kt.getMaToaThuoc(mals);
        }
        public bool themToaThuoc(string mals, string matt, string mat, int sb, int sl, int tong)
        {
            return dal_kt.themToaThuoc(mals, matt, mat, sb, sl, tong);
        }
        public int checkCTTT(string matt, string mat)
        {
            return dal_kt.checkCTTT(matt, mat);
        }
        public bool themToaThuoc_DaCo(string matt, string mat, int sb, int sl, int tong)
        {
            return dal_kt.themToaThuoc_DaCo(matt,mat, sb, sl, tong);
        }
        public bool capNhatThanhTien(string matt)
        {
            return dal_kt.capNhatThanhTien(matt);
        }
        public bool capNhatSoLuong(string mat, int sl)
        {
            return dal_kt.capNhatSoLuong(mat, sl);
        }
        public bool updateCT(CT_TOATHUOC tt)
        {
            return dal_kt.updateCT(tt);
        }
        public int checkTT(string mals)
        {
            return dal_kt.checkTT(mals);
        }
        public string getMaT(string tent)
        {
            return dal_kt.getMaT(tent);
        }
        public int getSoLuong(string matt, string mat)
        {
            return dal_kt.getSoLuong(matt, mat);
        }
        public bool xoaCT(string matt, string mat)
        {
            return dal_kt.xoaCT(matt, mat);
        }
    }
}
