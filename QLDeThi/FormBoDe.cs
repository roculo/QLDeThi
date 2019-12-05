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
    public partial class FormBoDe : Form
    {
        DETHI_DBEntities db = new DETHI_DBEntities();
        public FormBoDe()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvBD.DataSource = db.BoDes.Select(x => new { x.CAUHOI, x.MAMH, x.TRINHDO, x.NOIDUNG, x.A
            ,x.B,x.C,x.D,x.DAPAN,x.MAGV}).ToList();

        }
        private void dgvBD_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvBD.CurrentCell.RowIndex;
            lbCauHoi.Text = dgvBD.Rows[index].Cells[0].Value.ToString();
            txtMaMH.Text = dgvBD.Rows[index].Cells[1].Value.ToString();
            txtTRinh.Text = dgvBD.Rows[index].Cells[2].Value.ToString();
            txtNoiDung.Text = dgvBD.Rows[index].Cells[3].Value.ToString();
            txtA.Text = dgvBD.Rows[index].Cells[4].Value.ToString();
            txtB.Text = dgvBD.Rows[index].Cells[5].Value.ToString();
            txtC.Text = dgvBD.Rows[index].Cells[6].Value.ToString();
            txtD.Text = dgvBD.Rows[index].Cells[7].Value.ToString();
            txtDapAn.Text = dgvBD.Rows[index].Cells[8].Value.ToString();
            txtMaGV.Text = dgvBD.Rows[index].Cells[9].Value.ToString();
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


                BoDe bd = new BoDe();
                bd.CAUHOI = db.BoDes.ToList().Last().CAUHOI + 1;//Phai co Cau Hoi Dau Tien
                bd.MAMH = txtMaMH.Text;
                bd.TRINHDO = txtTRinh.Text;
                bd.NOIDUNG = txtNoiDung.Text;
                bd.A = txtA.Text;
                bd.B = txtB.Text;
                bd.C = txtC.Text;
                bd.D = txtD.Text;
                bd.DAPAN = txtDapAn.Text;
                bd.MAGV = FormLogin.MGV;

                db.BoDes.Add(bd);
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
            BoDe bd = db.BoDes.Find(Int16.Parse(lbCauHoi.Text));
            db.BoDes.Remove(bd);
            db.SaveChanges();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BoDe bd = db.BoDes.Find(Int16.Parse( lbCauHoi.Text));
                bd.MAMH = txtMaMH.Text;
                bd.TRINHDO = txtTRinh.Text;
                bd.NOIDUNG = txtNoiDung.Text;
                bd.A = txtA.Text;
                bd.B = txtB.Text;
                bd.C = txtC.Text;
                bd.D = txtD.Text;
                bd.DAPAN = txtDapAn.Text;
                bd.MAGV = txtMaGV.Text;
                
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
            var lst = db.BoDes.Select(x => new {
                x.CAUHOI,
                x.MAMH,
                x.TRINHDO,
                x.NOIDUNG,
                x.A
            ,
                x.B,
                x.C,
                x.D,
                x.DAPAN,
                x.MAGV
            }).Where(p => p.NOIDUNG.Contains(txtNoiDung.Text)).ToList();
            dgvBD.DataSource = lst;
        }
    }
}
