using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhan
    {
        string mabn;
        string lskb;
        string tenbn;
        int stt;

        public BenhNhan()
        {
        }

        public string MABN { get => mabn; set => mabn = value; }
        public string LSKB { get => lskb; set => lskb = value; }
        public string TENBN { get => tenbn; set => tenbn = value; }
        public int STT { get => stt; set => stt = value; }
    }
}
