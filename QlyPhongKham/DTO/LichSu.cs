using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSu:BenhNhan
    {
        public LichSu() { }
        DateTime? ngay;

        public DateTime? NGAY { get => ngay; set => ngay = value; }
    }
}
