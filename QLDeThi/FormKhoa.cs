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
    public partial class FormKhoa : Form
    {
        DETHI_DBEntities db = new DETHI_DBEntities();
        public FormKhoa()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvKhoa.DataSource = db.Khoas.Select(x => new { x.MAKH, x.TENKH, x.MACS }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiem tra server hien tai
            if (db.Khoas.Any(p => p.MAKH == txtMK.Text))
            {
                MessageBox.Show("Mã Khoa tồn tại ở server này");
                return;
            }
            //Kiem tra server khac
            if (db.sp_kiemtraMaKhoa1(txtMK.Text).First().ToString() == "1")
            {
                MessageBox.Show("Mã Khoa đã tồn tại ở server khác");
                return;
            }
            
            try
            {
                Khoa khoa = new Khoa();
                khoa.TENKH = txtTK.Text;
                khoa.MAKH = txtMK.Text;
                khoa.MACS = txtCS.Text;
                db.Khoas.Add(khoa);
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
            try
            {
                Khoa khoa = db.Khoas.Find(txtMK.Text);
                db.Khoas.Remove(khoa);
                db.SaveChanges();
                loadData();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Khoa khoa = db.Khoas.Find(txtMK.Text);
                khoa.TENKH = txtTK.Text;
                khoa.MAKH = txtMK.Text;
                khoa.MACS = txtCS.Text;
                db.SaveChanges();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var lst = db.Khoas.Select(x => new { x.MAKH, x.TENKH, x.MACS }).Where(p => p.TENKH.Contains(txtTK.Text) && p.MAKH.Contains(txtMK.Text)).ToList();
            dgvKhoa.DataSource = lst;
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvKhoa.CurrentCell.RowIndex;
            txtMK.Text = dgvKhoa.Rows[index].Cells[0].Value.ToString();
            txtTK.Text = dgvKhoa.Rows[index].Cells[1].Value.ToString();
            txtCS.Text = dgvKhoa.Rows[index].Cells[2].Value.ToString();
        }
    }
}
