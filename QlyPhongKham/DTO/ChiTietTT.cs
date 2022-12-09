using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietTT
    {
        public ChiTietTT()
        {
        }
        string tent, matt;

        public string MATT
        {
            get { return matt; }
            set { matt = value; }
        }

        public string TENT
        {
            get { return tent; }
            set { tent = value; }
        }
        double? dongia;

        public double? DONGIA
        {
            get { return dongia; }
            set { dongia = value; }
        }
        int soluong;

        public int SOLUONG
        {
            get { return soluong; }
            set { soluong = value; }
        }

        //public string TENT { get => tent; set => tent = value; }
        //public string MATT { get => matt; set => matt = value; }
        //public double? DONGIA { get => dongia; set => dongia = value; }
        //public int SOLUONG { get => soluong; set => soluong = value; }
    }
}
