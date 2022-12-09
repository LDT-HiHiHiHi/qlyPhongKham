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

        public string TENBN
        {
            get { return tenbn; }
            set { tenbn = value; }
        }

        public string MACD
        {
            get { return macd; }
            set { macd = value; }
        }
        DateTime? day;

        public DateTime? DAY
        {
            get { return day; }
            set { day = value; }
        }
        public ThanhToanDV()
        {
        }

        //public string MACD { get => macd; set => macd = value; }
        //public string TENBN { get => tenbn; set => tenbn = value; }
        //public DateTime? DAY { get => day; set => day = value; }
    }
}
