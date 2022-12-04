using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThanhToanTT
    {
        string matt, tenbn;
        DateTime? day;
        public ThanhToanTT()
        {
        }

        public string MATT { get => matt; set => matt = value; }
        public string TENBN { get => tenbn; set => tenbn = value; }
        public DateTime? DAY { get => day; set => day = value; }
    }
}
