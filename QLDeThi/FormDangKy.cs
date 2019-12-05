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
    public partial class FormDangKy : Form
    {
        DETHI_DBEntities db = new DETHI_DBEntities();
        public FormDangKy()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvDK.DataSource = db.GiaoVien_DangKy.Select(x => new {
                x.MAGV,
                x.MALOP,
                x.MAMH,
                x.TRINHDO,
                x.NGAYTHI
            ,
                x.LAN,
                x.SOCAUTHI,
                x.THOIGIAN,
            }).ToList();

        }

        private void dgvDK_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvDK.CurrentCell.RowIndex;
            txtMaGV.Text = dgvDK.Rows[index].Cells[0].Value.ToString();
            txtML.Text = dgvDK.Rows[index].Cells[1].Value.ToString();
            txtMaMH.Text = dgvDK.Rows[index].Cells[2].Value.ToString();
            txtTrinh.Text = dgvDK.Rows[index].Cells[3].Value.ToString();
            txtNgayThi.Text = dgvDK.Rows[index].Cells[4].Value.ToString();
            txtLan.Text = dgvDK.Rows[index].Cells[5].Value.ToString();
            txtSoCau.Text = dgvDK.Rows[index].Cells[6].Value.ToString();
            txtThoiGian.Text = dgvDK.Rows[index].Cells[7].Value.ToString();
            if (txtMaGV.Text.Contains(FormLogin.MGV))
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {


                GiaoVien_DangKy dk = new GiaoVien_DangKy();
                dk.MAGV = FormLogin.MGV;
                dk.MALOP = txtML.Text;
                dk.MAMH = txtMaMH.Text;
                dk.TRINHDO = txtTrinh.Text;
                dk.NGAYTHI = Convert.ToDateTime( txtNgayThi.Text);
                dk.LAN = Int16.Parse(txtLan.Text);
                dk.SOCAUTHI = Int16.Parse( txtSoCau.Text);
                dk.THOIGIAN =Int16.Parse( txtThoiGian.Text);

                db.GiaoVien_DangKy.Add(dk);
                db.SaveChanges();
                loadData();
        }
            catch (Exception ex)
            {
                MessageBox.Show("Không đúng định dạng" + ex);
            }
}

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            GiaoVien_DangKy dk = db.GiaoVien_DangKy.Find(txtML.Text,txtMaMH.Text, Int16.Parse(txtLan.Text));
            db.GiaoVien_DangKy.Remove(dk);
            db.SaveChanges();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {


                GiaoVien_DangKy dk = db.GiaoVien_DangKy.Find(txtML.Text, txtMaMH.Text, Int16.Parse(txtLan.Text));
                dk.MAGV = txtMaGV.Text;
                dk.MALOP = txtML.Text;
                dk.MAMH = txtMaMH.Text;
                dk.TRINHDO = txtTrinh.Text;
                dk.NGAYTHI = Convert.ToDateTime(txtNgayThi.Text);
                dk.LAN = Int16.Parse(txtLan.Text);
                dk.SOCAUTHI = Int16.Parse(txtSoCau.Text);
                dk.THOIGIAN = Int16.Parse(txtThoiGian.Text);
                
                db.SaveChanges();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đúng định dạng" + ex);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var lst = db.GiaoVien_DangKy.Select(x => new {
                x.MAGV,
                x.MALOP,
                x.MAMH,
                x.TRINHDO,
                x.NGAYTHI
            ,
                x.LAN,
                x.SOCAUTHI,
                x.THOIGIAN,
            }).Where(p => p.MAGV.Contains(txtMaGV.Text)).ToList();
            dgvDK.DataSource = lst;
        }
    }
}
