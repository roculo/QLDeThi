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
    public partial class FormLop : Form
    {
        DETHI_DBEntities db = new DETHI_DBEntities();
        public FormLop()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvLop.DataSource = db.Lops.Select(x => new { x.MALOP, x.TENLOP, x.MAKH }).ToList();
        }

        private void dgvLop_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvLop.CurrentCell.RowIndex;
            txtML.Text = dgvLop.Rows[index].Cells[0].Value.ToString();
            txtTL.Text = dgvLop.Rows[index].Cells[1].Value.ToString();
            txtMK.Text = dgvLop.Rows[index].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiem tra server hien tai
            if (db.Lops.Any(p => p.MALOP == txtML.Text))
            {
                MessageBox.Show("Mã Lớp tồn tại ở server này");
                return;
            }
            //Kiem tra server khac
            if (db.sp_kiemtraMaLop1(txtML.Text).First().ToString() == "1")
            {
                MessageBox.Show("Mã Lớp đã tồn tại ở server khác");
                return;
            }
            try
            {
                Lop lop = new Lop();
                lop.TENLOP = txtTL.Text;
                lop.MALOP = txtML.Text;
                lop.MAKH = txtMK.Text;
                db.Lops.Add(lop);
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
            Lop lop = db.Lops.Find(txtML.Text);
            db.Lops.Remove(lop);
            db.SaveChanges();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Lop lop =db.Lops.Find(txtML.Text);
                lop.TENLOP = txtTL.Text;
                lop.MALOP = txtML.Text;
                lop.MAKH = txtMK.Text;
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
            var lst = db.Lops.Select(x => new { x.MALOP, x.TENLOP, x.MAKH }).Where(p => p.TENLOP.Contains(txtTL.Text) && p.MALOP.Contains(txtML.Text)).ToList();
            dgvLop.DataSource = lst;
        }
    }
}
