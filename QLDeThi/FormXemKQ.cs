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
    public partial class FormXemKQ : Form
    {
        DETHI_DBEntities db = new DETHI_DBEntities();

        public FormXemKQ()
        {
            InitializeComponent();
            loadData();

        }
        public void loadData()
        {
            dgvMonHoc.DataSource = db.BangDiems.Where(p => p.MASV == FormLogin.MSSV).Select(p => new
            {
                p.MASV,
                p.MAMH,
                p.LAN,
                p.NGAYTHI,
                p.DIEM
            }).ToList();
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonHoc.Focused)
            {

                int index = dgvMonHoc.CurrentCell.RowIndex;
                String MSV = dgvMonHoc.Rows[index].Cells[0].Value.ToString();
                String MaMH = dgvMonHoc.Rows[index].Cells[1].Value.ToString();
                String Lan = dgvMonHoc.Rows[index].Cells[2].Value.ToString();
                String Ngaythi = dgvMonHoc.Rows[index].Cells[3].Value.ToString();
                dgvKQ.DataSource = db.KQ_Thi.Where(p => p.MSV.Contains(MSV) && p.MAMH.Contains(MaMH)).Select(p => new { p.CAUHOI, p.CHOSE, p.DAPAN }).ToList();

            }
        }
    }
}
