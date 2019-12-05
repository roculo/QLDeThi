using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDeThi
{
    public partial class FormMenuSV : Form
    {
        public FormMenuSV()
        {
            InitializeComponent();
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            FormThamGiaThi newform = new FormThamGiaThi();
            newform.Show();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            FormXemKQ newform = new FormXemKQ();
            newform.Show();
        }
    }
}
