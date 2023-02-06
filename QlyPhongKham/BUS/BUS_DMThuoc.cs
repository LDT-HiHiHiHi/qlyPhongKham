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
    public class BUS_DMThuoc
    {
        DAL_DMThuoc dal_dmt = new DAL_DMThuoc();
        public List<DMThuoc> getListThuoc()
        {
            return dal_dmt.getListThuoc();
        }

        public bool themThuoc(DMTHUOC thuoc, DONGIA_THUOC dg)
        {
            return dal_dmt.themThuoc(thuoc, dg);
        }
        public bool capNhatThuoc(DMTHUOC thuoc, DONGIA_THUOC dg)
        {
            return dal_dmt.capNhatThuoc(thuoc, dg);
        }
        public bool xoaThuoc(string mat)
        {
            return dal_dmt.xoaThuoc(mat);
        }

        public int checkThuoc(string mat)
        {
            return dal_dmt.checkThuoc(mat);
        }

        public DateTime? getDay(string mat)
        {
            return dal_dmt.getDay(mat);
        }

        public DataTable timKiemThuoc(string ten)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MAT", typeof(string)));
            dt.Columns.Add(new DataColumn("TENT", typeof(string)));
            dt.Columns.Add(new DataColumn("HSD", typeof(string)));
            dt.Columns.Add(new DataColumn("SL", typeof(int)));
            dt.Columns.Add(new DataColumn("DVT", typeof(string)));
            dt.Columns.Add(new DataColumn("NGCN", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("DG", typeof(double)));
            dal_dmt.timKiemThuoc(ten).ForEach(tk =>
            {
                DataRow r = dt.NewRow();
                r["MAT"] = tk.MAT;
                r["TENT"] = tk.TENT;
                r["HSD"] = tk.HSD;
                r["SL"] = tk.SL;
                r["DVT"] = tk.DVT;
                r["NGCN"] = tk.NGCN;
                r["DG"] = tk.DG;
                dt.Rows.Add(r);
            });
            return dt;
        }
    }
}
