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
    public partial class FormMenuGV : Form
    {
        public FormMenuGV()
        {
            InitializeComponent();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            FormDangKy newform = new FormDangKy();

            newform.Show();
        }

        private void btnCauHoi_Click(object sender, EventArgs e)
        {
            FormBoDe newform = new FormBoDe();

            newform.Show();
        }

        private void btnBaiNop_Click(object sender, EventArgs e)
        {
            FormXemDiem newform = new FormXemDiem();
            newform.Show();
        }
    }
}
