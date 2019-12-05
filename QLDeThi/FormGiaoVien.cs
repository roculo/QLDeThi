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
    public partial class FormGiaoVien : Form
    {
        DETHI_DBEntities db = new DETHI_DBEntities();
        public FormGiaoVien()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvGV.DataSource = db.GiaoViens.Select(x => new { x.MAGV, x.HO, x.TEN, x.HOCVI, x.MAKH }).ToList();
        }
        private void dgvGV_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvGV.CurrentCell.RowIndex;
            txtMGV.Text = dgvGV.Rows[index].Cells[0].Value.ToString();
            txtHo.Text = dgvGV.Rows[index].Cells[1].Value.ToString();
            txtTen.Text = dgvGV.Rows[index].Cells[2].Value.ToString();
            txtHocVi.Text = dgvGV.Rows[index].Cells[3].Value.ToString();
            txtMaKhoa.Text = dgvGV.Rows[index].Cells[4].Value.ToString();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiem tra server hien tai
            if (db.GiaoViens.Any(p => p.MAGV == txtMGV.Text))
            {
                MessageBox.Show("Mã Giảng Viên đã tồn tại ở server này");
                return;
            }
            //Kiem tra server khac
            if (db.sp_kiemtraMaGV1(txtMGV.Text).First().ToString() == "1")
            {
                MessageBox.Show("Mã Khoa đã tồn tại ở server khác");
                return;
            }
            try
            {

                GiaoVien gv = new GiaoVien();
                gv.MAGV = txtMGV.Text;
                gv.HO = txtHo.Text;
                gv.TEN = txtTen.Text;
                gv.HOCVI = txtHocVi.Text;
                gv.MAKH = txtMaKhoa.Text;
                db.GiaoViens.Add(gv);
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
            GiaoVien gv = db.GiaoViens.Find(txtMGV.Text);
            db.GiaoViens.Remove(gv);
            db.SaveChanges();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVien gv = db.GiaoViens.Find(txtMGV.Text);
                gv.MAGV = txtMGV.Text;
                gv.HO = txtHo.Text;
                gv.TEN = txtTen.Text;
                gv.HOCVI = txtHocVi.Text;
                gv.MAKH = txtMaKhoa.Text;
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
            var lst = db.GiaoViens.Select(x => new { x.MAGV, x.HO, x.TEN, x.HOCVI, x.MAKH }).Where(p => p.MAGV.Contains(txtMGV.Text)).ToList();
            dgvGV.DataSource = lst;
        }
    }
}
