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
    public class BUS_ThanhToanDV
    {
        DAL_ThanhToanDV dal_dv = new DAL_ThanhToanDV();
        public List<ThanhToanDV> getListCD()
        {
            return dal_dv.getListCD();
        }

        public List<ThanhToanDV> getListCD_Today()
        {
            return dal_dv.getListCD_Today();
        }
        public DataTable timKiemCD(string macd)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MACD", typeof(string)));
            dt.Columns.Add(new DataColumn("TENBN", typeof(string)));
            dt.Columns.Add(new DataColumn("DAY", typeof(DateTime)));
            dal_dv.timKiemCD(macd).ForEach(tk =>
            {
                DataRow r = dt.NewRow();
                r["MACD"] = tk.MACD;
                r["TENBN"] = tk.TENBN;
                r["DAY"] = tk.DAY;
                dt.Rows.Add(r);
            });
            return dt;
        }

        public DataTable timKiemCD_Today(string macd)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MACD", typeof(string)));
            dt.Columns.Add(new DataColumn("TENBN", typeof(string)));
            dt.Columns.Add(new DataColumn("DAY", typeof(DateTime)));
            dal_dv.timKiemCD_Today(macd).ForEach(tk =>
            {
                DataRow r = dt.NewRow();
                r["MACD"] = tk.MACD;
                r["TENBN"] = tk.TENBN;
                r["DAY"] = tk.DAY;
                dt.Rows.Add(r);
            });
            return dt;
        }

        public int checkCTCD(string macd)
        {
            return dal_dv.checkCTCD(macd);
        }

        public double getTongTien(string macd)
        {
            return dal_dv.getTongTien(macd);
        }

        public bool getTrangThai(string macd)
        {
            return dal_dv.getTrangThai(macd);
        }

        public bool capNhatTrangThai(string macd)
        {
            return dal_dv.capNhatTrangThai(macd);
        }
    }
}
