using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThanhToanDV
    {
        string macd, tenbn;
        DateTime? day;
        public ThanhToanDV()
        {
        }

        public string MACD { get => macd; set => macd = value; }
        public string TENBN { get => tenbn; set => tenbn = value; }
        public DateTime? DAY { get => day; set => day = value; }
    }
}
