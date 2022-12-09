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

        public string MABN
        {
          get { return mabn; }
          set { mabn = value; }
        }
        string lskb;

        public string LSKB
        {
          get { return lskb; }
          set { lskb = value; }
        }
        string tenbn;

        public string TENBN
        {
          get { return tenbn; }
          set { tenbn = value; }
        }
        int stt;

        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }

        public BenhNhan()
        {
        }

        //public string MABN { get => mabn; set => mabn = value; }
        //public string LSKB { get => lskb; set => lskb = value; }
        //public string TENBN { get => tenbn; set => tenbn = value; }
        //public int STT { get => stt; set => stt = value; }
    }
}
