using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DMThuoc
    {
        string mat, tent, hsd, dvt;
        int? sl;
        DateTime? ngcn;
        double? dg;

        public DMThuoc()
        {
        }

        public string MAT { get => mat; set => mat = value; }
        public string TENT { get => tent; set => tent = value; }
        public string HSD { get => hsd; set => hsd = value; }
        public string DVT { get => dvt; set => dvt = value; }
        public int? SL { get => sl; set => sl = value; }
        public DateTime? NGCN { get => ngcn; set => ngcn = value; }
        public double? DG { get => dg; set => dg = value; }
    }
}
