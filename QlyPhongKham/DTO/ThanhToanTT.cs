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

        public string TENBN
        {
            get { return tenbn; }
            set { tenbn = value; }
        }

        public string MATT
        {
            get { return matt; }
            set { matt = value; }
        }
        DateTime? day;

        public DateTime? DAY
        {
            get { return day; }
            set { day = value; }
        }
        public ThanhToanTT()
        {
        }

        //public string MATT { get => matt; set => matt = value; }
        //public string TENBN { get => tenbn; set => tenbn = value; }
        //public DateTime? DAY { get => day; set => day = value; }
    }
}
