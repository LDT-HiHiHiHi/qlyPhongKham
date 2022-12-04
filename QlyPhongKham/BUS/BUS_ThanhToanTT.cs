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
    public class BUS_ThanhToanTT
    {
        DAL_ThanhToanTT dal_tt = new DAL_ThanhToanTT();
        public List<ThanhToanTT> getListTT_Today()
        {
            return dal_tt.getListTT_Today();
        }
        public DataTable timKiemTT_Today(string matt)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MATT", typeof(string)));
            dt.Columns.Add(new DataColumn("TENBN", typeof(string)));
            dt.Columns.Add(new DataColumn("DAY", typeof(DateTime)));
            dal_tt.timKiemTT_Today(matt).ForEach(tk =>
            {
                DataRow r = dt.NewRow();
                r["MATT"] = tk.MATT;
                r["TENBN"] = tk.TENBN;
                r["DAY"] = tk.DAY;
                dt.Rows.Add(r);
            });
            return dt;
        }
        public List<ChiTietTT> getListCT(string matt)
        {
            return dal_tt.getListCT(matt);
        }
        public int checkCTTT(string matt)
        {
            return dal_tt.checkCTTT(matt);
        }
        public bool getTrangThai(string matt)
        {
            return dal_tt.getTrangThai(matt);
        }
        public double getTongTien(string matt)
        {
            return dal_tt.getTongTien(matt);
        }
        public bool capNhatTrangThai(string matt)
        {
            return dal_tt.capNhatTrangThai(matt);
        }
    }
}
