using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuCD
    {
        public ChiTietPhieuCD()
        {
        }
        string tendv, macd, ketqua, mota, hinhanh;

        public string HINHANH
        {
            get { return hinhanh; }
            set { hinhanh = value; }
        }

        public string MOTA
        {
          get { return mota; }
          set { mota = value; }
        }

        public string KETQUA
        {
          get { return ketqua; }
          set { ketqua = value; }
        }

        public string MACD
        {
          get { return macd; }
          set { macd = value; }
        }

        public string TENDV
        {
          get { return tendv; }
          set { tendv = value; }
        }
        double? dongia;

        public double? DONGIA
        {
          get { return dongia; }
          set { dongia = value; }
        }

        //public string TENDV { get => tendv; set => tendv = value; }
        //public string MACD { get => macd; set => macd = value; }
        //public string KETQUA { get => ketqua; set => ketqua = value; }
        //public string MOTA { get => mota; set => mota = value; }
        //public double? DONGIA { get => dongia; set => dongia = value; }
        //public string HINHANH { get => hinhanh; set => hinhanh = value; }
    }
}
