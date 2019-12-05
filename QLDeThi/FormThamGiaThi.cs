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
    public partial class FormThamGiaThi : Form
    {
        DETHI_DBEntities db = new DETHI_DBEntities();
        public static String Trinhdo_DKThi;
        public static String MAMH_DKThi;
        public static String Ngay_DKThi;
        public static String Lan_DKThi;
        public static int SoCau_DKThi;
        public static int ThoiGian_DKTHI;

        public FormThamGiaThi()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvDSThi.DataSource = db.GiaoVien_DangKy.Select(x => new { x.MAGV, x.MALOP, x.MAMH,x.TRINHDO,x.NGAYTHI,x.LAN,x.SOCAUTHI,x.THOIGIAN }).ToList();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSThi_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvDSThi.CurrentCell.RowIndex;
            MAMH_DKThi = dgvDSThi.Rows[index].Cells[2].Value.ToString();
            Trinhdo_DKThi = dgvDSThi.Rows[index].Cells[3].Value.ToString();
            Ngay_DKThi = dgvDSThi.Rows[index].Cells[4].Value.ToString();
            Lan_DKThi = dgvDSThi.Rows[index].Cells[5].Value.ToString();
            SoCau_DKThi =Int16.Parse( dgvDSThi.Rows[index].Cells[6].Value.ToString());
            ThoiGian_DKTHI = Int16.Parse(dgvDSThi.Rows[index].Cells[7].Value.ToString());
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            FormLamBaiThi newform = new FormLamBaiThi();
            newform.Show();
            this.Hide();
        }
    }
}
