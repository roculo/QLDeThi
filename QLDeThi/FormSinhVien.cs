using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDeThi
{
    public partial class FormSinhVien : Form
    {
        DETHI_DBEntities db = new DETHI_DBEntities();
        public FormSinhVien()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvSV.DataSource = db.SinhViens.Select(x => new { x.MASV, x.HO, x.TEN, x.NGAYSINH, x.DIACHI, x.MALOP }).ToList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvSV_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvSV.CurrentCell.RowIndex;
            txtMSSV.Text = dgvSV.Rows[index].Cells[0].Value.ToString();
            txtHo.Text = dgvSV.Rows[index].Cells[1].Value.ToString();
            txtTen.Text = dgvSV.Rows[index].Cells[2].Value.ToString();
            txtNgaySinh.Text = dgvSV.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvSV.Rows[index].Cells[4].Value.ToString();
            txtML.Text = dgvSV.Rows[index].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiem tra server hien tai
            //if (db.SinhViens.Any(p => p.MASV == txtMSSV.Text))
            //{
            //    MessageBox.Show("Mã Sinh Viên tồn tại ở server này");
            //    return;
            //}
            //Kiem tra server khac
            if (db.sp_kiemtraMaSV1(txtMSSV.Text).First().ToString() == "1")
            {
                MessageBox.Show("Mã Sinh Viên đã tồn tại ở server khác");
                return;
            }
            try
            {
                SinhVien sv = new SinhVien();
                sv.MASV = txtMSSV.Text;
                sv.HO = txtHo.Text;
                sv.TEN = txtTen.Text;
                sv.NGAYSINH = Convert.ToDateTime(txtNgaySinh.Text);
                sv.DIACHI = txtDiaChi.Text;
                sv.MALOP = txtML.Text;
                db.SinhViens.Add(sv);
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
            SinhVien sv = db.SinhViens.Find(txtMSSV.Text);
            db.SinhViens.Remove(sv);
            db.SaveChanges();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = db.SinhViens.Find(txtMSSV.Text);
                sv.MASV = txtMSSV.Text;
                sv.HO = txtHo.Text;
                sv.TEN = txtTen.Text;
                sv.NGAYSINH = Convert.ToDateTime(txtNgaySinh.Text);
                sv.DIACHI = txtDiaChi.Text;
                sv.MALOP = txtML.Text;
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
            var lst = db.SinhViens.Select(x => new { x.MASV, x.HO, x.TEN, x.NGAYSINH, x.DIACHI, x.MALOP }).Where(p => p.MASV.Contains(txtMSSV.Text)).ToList();
            dgvSV.DataSource = lst;
        }
    }
}
