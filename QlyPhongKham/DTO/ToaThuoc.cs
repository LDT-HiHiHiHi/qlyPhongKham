using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ToaThuoc
    {
        string matt, tent;
        int sb, sl, tong;
        double dongia;
        public ToaThuoc()
        {

        }

        public string MATT { get => matt; set => matt = value; }
        public string TENT { get => tent; set => tent = value; }
        public int SB { get => sb; set => sb = value; }
        public int SL { get => sl; set => sl = value; }
        public int TONG { get => tong; set => tong = value; }
        public double DONGIA { get => dongia; set => dongia = value; }
    }
}
