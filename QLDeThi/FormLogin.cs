using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDeThi
{
    public partial class FormLogin : Form
    {
       
        public static String MGV,MSSV;
        DETHI_DBEntities db = new DETHI_DBEntities();
        public FormLogin()
        {
            InitializeComponent();
            txtSvPass.Text = "123";
            txtMSSV.Text = "51503358";
            txtMGV.Text = "CNTT01  ";
            txtGvPass.Text = "123";
        }
     

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if(rbnCS1.Checked==true)
            {
                FormMenuCS newform = new FormMenuCS();
                newform.Show();
                this.Hide();
            }
            if (rbnCS2.Checked == true)
            {

            }
            if (rbnTruong.Checked == true)
            {
             
                FormMenuCS newform = new FormMenuCS();
                newform.Show();
                this.Hide();
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (db.SinhViens.Any(s => s.MASV == txtId.Text) || db.GiaoViens.Any(s => s.MAGV == txtId.Text))
            {
                if (txtRegisterPass.Text != txtRegisterRePass.Text)
                {
                    MessageBox.Show("Password ko giống");
                    return;
                }
                try
                {
                    Login lg = new Login();
                    lg.username = txtId.Text;
                    lg.pass = txtRegisterPass.Text;
                    db.Logins.Add(lg);
                    db.SaveChanges();
                    MessageBox.Show("Completed");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            else
            {
                MessageBox.Show("Id không tồn tại");
            }
        
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            try
            {
                Login lg = db.Logins.Find(txtMGV.Text);
                if (lg.pass == txtGvPass.Text)
                {
                    MGV = lg.username;
                    FormMenuGV newform = new FormMenuGV();
                    this.Hide();
                    newform.Show();
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            catch
            {
                MessageBox.Show("Mã Giảng Viên sai hoặc Pass không đúng");
            }
       
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            try
            {
                Login lg = db.Logins.Find(txtMSSV.Text);
                if (lg.pass == txtSvPass.Text)
                {
                    MSSV = lg.username;
                    FormMenuSV newform = new FormMenuSV();
                    this.Hide();
                    newform.Show();
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            catch
            {
                MessageBox.Show("Mã Sinh Viên sai hoặc Pass không đúng");
            }
        }
    }
}
