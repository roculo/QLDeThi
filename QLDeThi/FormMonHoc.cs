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
    public partial class FormMonHoc : Form
    {
        DETHI_DBEntities db = new DETHI_DBEntities();
        public FormMonHoc()
        {
            InitializeComponent();
            loadData();
        }
      
        public void loadData()
        {
            dgvMonHoc.DataSource = db.MonHocs.Select(x => new { x.MAMH, x.TENMH }).ToList();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MonHoc monhoc = new MonHoc();
                monhoc.MAMH = txtMaMH.Text;
                monhoc.TENMH = txtTenMH.Text;
                db.MonHocs.Add(monhoc);
                db.SaveChanges();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đúng định dạng"+ex);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
     
                MonHoc monhoc = db.MonHocs.Find(txtMaMH.Text);
                db.MonHocs.Remove(monhoc);
                db.SaveChanges();
                loadData();
       
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                MonHoc monhoc = db.MonHocs.Find(txtMaMH.Text);
                monhoc.TENMH = txtTenMH.Text;
                monhoc.TENMH = txtTenMH.Text;
                db.SaveChanges();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đúng định dạng"+ex);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var lst=db.MonHocs.Select(x => new { x.MAMH, x.TENMH }).Where(p => p.TENMH.Contains(txtTenMH.Text)&&p.MAMH.Contains(txtMaMH.Text)).ToList();
            dgvMonHoc.DataSource = lst;
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvMonHoc.CurrentCell.RowIndex;
            txtMaMH.Text = dgvMonHoc.Rows[index].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMonHoc.Rows[index].Cells[1].Value.ToString();
        }
    }
}
