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

        public string TENT
        {
            get { return tent; }
            set { tent = value; }
        }

        public string MATT
        {
            get { return matt; }
            set { matt = value; }
        }
        int sb, sl, tong;

        public int TONG
        {
            get { return tong; }
            set { tong = value; }
        }

        public int SL
        {
            get { return sl; }
            set { sl = value; }
        }

        public int SB
        {
            get { return sb; }
            set { sb = value; }
        }
        double dongia;

        public double DONGIA
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public ToaThuoc()
        {

        }

        //public string MATT { get => matt; set => matt = value; }
        //public string TENT { get => tent; set => tent = value; }
        //public int SB { get => sb; set => sb = value; }
        //public int SL { get => sl; set => sl = value; }
        //public int TONG { get => tong; set => tong = value; }
        //public double DONGIA { get => dongia; set => dongia = value; }
    }
}
