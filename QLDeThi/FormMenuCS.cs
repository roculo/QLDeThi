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
    public partial class FormMenuCS : Form
    {
        public FormMenuCS()
        {
            InitializeComponent();
        }

        private void btnNhapMonHoc_Click(object sender, EventArgs e)
        {
            FormMonHoc newform = new FormMonHoc();
            newform.Show();
           
        }

        private void btnNhapKhoa_Click(object sender, EventArgs e)
        {
            FormKhoa newform = new FormKhoa();
            newform.Show();
        }

        private void btnNhapLop_Click(object sender, EventArgs e)
        {
            FormLop newform = new FormLop();
            newform.Show();
        }

        private void btnNhapSinhVien_Click(object sender, EventArgs e)
        {
            FormSinhVien newform = new FormSinhVien();
            newform.Show();
        }

        private void btnNhapGiangVien_Click(object sender, EventArgs e)
        {
            FormGiaoVien newform = new FormGiaoVien();
            newform.Show();
        }
    }
}
