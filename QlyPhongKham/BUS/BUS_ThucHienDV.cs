using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_ThucHienDV
    {
        DAL_ThucHienDV dal_th = new DAL_ThucHienDV();
        public List<ThanhToanDV> getListCD_Today()
        {
            return dal_th.getListCD_Today();
        }
        public List<ThanhToanDV> timKiemCD_Today(string macd)
        {
            return dal_th.timKiemCD_Today(macd);
        }
        public bool updateCTCD(string macd, string madv, string hinhanh, string ketqua)
        {
            return dal_th.updateCTCD(macd, madv, hinhanh, ketqua);
        }
    }
}
