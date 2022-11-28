using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class THUOC
    {
        string mat, tent;
        public THUOC()
        {
        }

        public string MAT { get => mat; set => mat = value; }
        public string TENT { get => tent; set => tent = value; }
    }
}
