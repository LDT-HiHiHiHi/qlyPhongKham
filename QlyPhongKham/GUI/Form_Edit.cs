using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class Form_Edit:Form
    {
        public TabControl tabCtrl;

        public Form_Edit()
        {
        }

        public TabPage tabPag;

        public TabPage TabPag
        {
            get
            {
                return tabPag;
            }
            set
            {
                tabPag = value;
            }
        }

        public TabControl TabCtrl
        {
            set
            {
                tabCtrl = value;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form_Edit
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form_Edit";
            this.ResumeLayout(false);

        }

    }
}
