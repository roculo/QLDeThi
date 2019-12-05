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
    public partial class FormLamBaiThi : Form
    {
        int quick = FormThamGiaThi.ThoiGian_DKTHI*60;
       
        DETHI_DBEntities db = new DETHI_DBEntities();
        List<KQ_Thi> dethi= new List<KQ_Thi>();
        List<String> dapan = new List<String>();
        List<BoDe> lst2 = new List<BoDe>();
        public FormLamBaiThi()
        {
            
            InitializeComponent();
            lbLan.Text ="Lần :" +FormThamGiaThi.Lan_DKThi;
            lbMaMH.Text = FormThamGiaThi.MAMH_DKThi;
            lbTrinh.Text ="Trình :"+ FormThamGiaThi.Trinhdo_DKThi;
            lbNgayThi.Text ="Ngày :"+ FormThamGiaThi.Ngay_DKThi;
            lbMonThi.Text ="Môn :"+ db.MonHocs.Find(lbMaMH.Text).TENMH.ToString();
            var t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            quick--;
            var xx = (quick % 60);
            lbTime.Text = quick / 60 + ":" + (xx >= 10 ? xx.ToString() : "0" + xx.ToString());
        }
     
        public void loadData()
        {
             lst2 = db.BoDes.Where(p => p.MAMH == lbMaMH.Text).ToList<BoDe>();
            int i = 0;
            foreach (var x in lst2)
            {
                if(i==FormThamGiaThi.SoCau_DKThi)
                {
                    break;
                }
                KQ_Thi kq = new KQ_Thi();
                kq.CAUHOI = x.CAUHOI;
                kq.DAPAN = x.DAPAN;
                kq.LAN = Int16.Parse( FormThamGiaThi.Lan_DKThi);
                kq.MAMH = lbMaMH.Text;
                kq.MSV = FormLogin.MSSV;
                kq.CHOSE = "";
                kq.NgayThi = FormThamGiaThi.Ngay_DKThi;
                dethi.Add(kq);
                i++;
            }
            dgvCauHoi.DataSource = dethi.Select(p => new
            {
                CAUHOI = p.CAUHOI,
                DAPAN= p.CHOSE
            }).ToList();
          
        }

      
        int index,cautt;
        private void dgvCauHoi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCauHoi.Focused)
            {
                rbnA.Checked = false;
                rbnB.Checked = false;
                rbnC.Checked = false;
                rbnD.Checked = false;
                index = dgvCauHoi.CurrentCell.RowIndex;
                cautt = Int16.Parse(dgvCauHoi.Rows[index].Cells[0].Value.ToString());
                lbNoiDung.Text = lst2.Where(p => p.CAUHOI == cautt).SingleOrDefault().NOIDUNG;
                lbSTT.Text = "Câu : " + (index + 1);
                rbnA.Text = lst2.Where(p => p.CAUHOI == cautt).SingleOrDefault().A;
                rbnB.Text = lst2.Where(p => p.CAUHOI == cautt).SingleOrDefault().B;
                rbnC.Text = lst2.Where(p => p.CAUHOI == cautt).SingleOrDefault().C;
                rbnD.Text = lst2.Where(p => p.CAUHOI == cautt).SingleOrDefault().D;
            }

           
        }
       
        private void rbnA_CheckedChanged(object sender, EventArgs e)
        {

            
            var kq = dethi.Where(p => p.CAUHOI == cautt).First();
            kq.CHOSE = "A";
            dgvCauHoi.DataSource = dethi.Select(p => new
            {
                CAUHOI = p.CAUHOI,
                DAPAN = p.CHOSE
            }).ToList();
        }

        private void rbnB_CheckedChanged(object sender, EventArgs e)
        {
            var kq = dethi.Where(p => p.CAUHOI == cautt).First();
            kq.CHOSE = "B";
            dgvCauHoi.DataSource = dethi.Select(p => new
            {
                CAUHOI = p.CAUHOI,
                DAPAN = p.CHOSE
            }).ToList();
        }

        private void rbnC_CheckedChanged(object sender, EventArgs e)
        {
            var kq = dethi.Where(p => p.CAUHOI == cautt).First();
            kq.CHOSE = "C";
            dgvCauHoi.DataSource = dethi.Select(p => new
            {
                CAUHOI = p.CAUHOI,
                DAPAN = p.CHOSE
            }).ToList();
        }

        private void FormLamBaiThi_Load(object sender, EventArgs e)
        {
            loadData();
        }

  

        private void rbnD_CheckedChanged(object sender, EventArgs e)
        {
            var kq = dethi.Where(p => p.CAUHOI == cautt).First();
            kq.CHOSE = "D";
            dgvCauHoi.DataSource = dethi.Select(p => new
            {
                CAUHOI = p.CAUHOI,
                DAPAN = p.CHOSE
            }).ToList();
        }

    

        private void btnNop_Click(object sender, EventArgs e)
        {
            double diem = 0;
            foreach (var x in dethi)
            {
                if(x.CHOSE==x.DAPAN)
                {
                    diem=diem+1;
                    x.Correct = 1;
                }
                else
                {
                    x.Correct = 0;

                }
                db.KQ_Thi.Add(x);
                try
                {
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
           
            try
            {
                diem = diem / FormThamGiaThi.SoCau_DKThi * 10;
                BangDiem bangdiem = new BangDiem();
                bangdiem.MAMH = lbMaMH.Text;
                bangdiem.MASV = FormLogin.MSSV;
                bangdiem.LAN = Int16.Parse(FormThamGiaThi.Lan_DKThi);
                bangdiem.NGAYTHI = Convert.ToDateTime(FormThamGiaThi.Ngay_DKThi);
                bangdiem.DIEM = diem;
                bangdiem.BAITHI = "KQ";
                db.BangDiems.Add(bangdiem);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi"+ex.ToString());
            }
       
  
            MessageBox.Show("Bạn được " + diem + " Điểm");
            this.Close();
        }
    }
}
