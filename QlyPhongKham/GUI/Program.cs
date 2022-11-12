using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        public static Form formMain = null;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware(); 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

        public static void AlertMessage(string pMessage, MessageBoxIcon icon = MessageBoxIcon.Warning)
        {
            MessageBox.Show(pMessage, "Thông báo", MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult ConfirmMessage(string pMessage, MessageBoxIcon icon = MessageBoxIcon.Question)
        {
            return MessageBox.Show(pMessage, "Thông báo", MessageBoxButtons.YesNo, icon, MessageBoxDefaultButton.Button1);
        }
    }
}
