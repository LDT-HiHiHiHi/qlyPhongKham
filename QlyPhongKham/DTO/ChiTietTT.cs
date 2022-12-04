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
        double? dongia;
        int soluong;

        public string TENT { get => tent; set => tent = value; }
        public string MATT { get => matt; set => matt = value; }
        public double? DONGIA { get => dongia; set => dongia = value; }
        public int SOLUONG { get => soluong; set => soluong = value; }
    }
}
