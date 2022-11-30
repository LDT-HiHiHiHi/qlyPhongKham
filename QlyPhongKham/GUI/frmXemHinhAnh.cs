using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmXemHinhAnh : Form
    {
        public frmXemHinhAnh()
        {
            InitializeComponent();
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void frmXemHinhAnh_Load(object sender, EventArgs e)
        {
            string hinh = frmThucHienDichVu.HINH;
            if (!hinh.Equals("Chưa có"))
            {
                hienThi.Image = ByteToImg(frmThucHienDichVu.HINH);
            }       
        }
    }
}
