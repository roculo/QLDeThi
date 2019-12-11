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
    public partial class FormXemDiem : Form
    {
        DETHI_DBEntities db = new DETHI_DBEntities();
        public FormXemDiem()
        {
            InitializeComponent();
            loadData();
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prnDocument_PrintPage);
        }
        public void loadData()
        {
            dgvMonHoc.DataSource = db.GiaoVien_DangKy.Where(p => p.MAGV == FormLogin.MGV).Select(p => new
            {
                p.MAGV,
                p.MALOP,
                p.MAMH,
                p.TRINHDO,
                p.NGAYTHI,
                p.LAN,
                p.SOCAUTHI,
                p.THOIGIAN,
            }).ToList();
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonHoc.Focused)
            {

                int index = dgvMonHoc.CurrentCell.RowIndex;
                String MaMH = dgvMonHoc.Rows[index].Cells[2].Value.ToString();
                String Lan = dgvMonHoc.Rows[index].Cells[5].Value.ToString();
                String Ngaythi = dgvMonHoc.Rows[index].Cells[4].Value.ToString();
                bool result = db.BangDiems.First().NGAYTHI.ToString() == Ngaythi;
                dgvBaiNop.DataSource = db.BangDiems.Where(p => p.MAMH.Contains(MaMH)&&result==true ).Select(p => new { p.MASV, p.DIEM}).ToList();

            }
        }
        //--------------------------------------------------------------------------
        // for PrintDialog, PrintPreviewDialog and PrintDocument:
        private System.Drawing.Printing.PrintDocument prnDocument = new System.Drawing.Printing.PrintDocument();


        // for Invoice Head:
        private string InvTitle;
        private string InvSubTitle1;
        private string InvSubTitle15;
        private string InvSubTitle2;
        private string InvSubTitle3;

        // for Report:
        private int CurrentY;
        private int CurrentX;
        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;
        private int InvoiceWidth;
        private int InvoiceHeight;
        

        // Font and Color:------------------
        // Title Font
        private Font InvTitleFont = new Font("Arial", 24, FontStyle.Regular);
        // Title Font height
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 14, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        // Invoice Font
        private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        // Invoice Font height
        private int InvoiceFontHeight=0;
        // Blue Color
        private SolidBrush BlueBrush = new SolidBrush(Color.Blue);
        // Red Color
        private SolidBrush RedBrush = new SolidBrush(Color.Red);
        // Black Color
        private SolidBrush BlackBrush = new SolidBrush(Color.Black);
        private void SetInvoiceHead(Graphics g)
        {
            int index = dgvMonHoc.CurrentCell.RowIndex;
            //Titles and Image of invoice:
            String mamonhoc= dgvMonHoc.Rows[index].Cells[2].Value.ToString();
            InvTitle = "Bảng Điểm Môn Học";
            InvSubTitle1 = "Mã Môn Học: " + mamonhoc;
            InvSubTitle15 = "Tên Môn Học: " + db.MonHocs.Find(mamonhoc).TENMH.ToString();
            InvSubTitle2 = "Lần: " + dgvMonHoc.Rows[index].Cells[5].Value.ToString();
            InvSubTitle3 = "Ngày thi: " + dgvMonHoc.Rows[index].Cells[4].Value.ToString();

            CurrentY = topMargin;
            CurrentX = leftMargin;
            int ImageHeight = 0;
            InvTitleHeight = (int)(InvTitleFont.GetHeight(g));
            InvSubTitleHeight = (int)(InvSubTitleFont.GetHeight(g));

            // Get Titles Length:
            int lenInvTitle = (int)g.MeasureString(InvTitle, InvTitleFont).Width;
            int lenInvSubTitle1 = (int)g.MeasureString(InvSubTitle1, InvSubTitleFont).Width;
            int lenInvSubTitle15 = (int)g.MeasureString(InvSubTitle15, InvSubTitleFont).Width;
            int lenInvSubTitle2 = (int)g.MeasureString(InvSubTitle2, InvSubTitleFont).Width;
            int lenInvSubTitle3 = (int)g.MeasureString(InvSubTitle3, InvSubTitleFont).Width;
            // Set Titles Left:
            int xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
            int xInvSubTitle1 = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2;
            int xInvSubTitle15 = CurrentX + (InvoiceWidth - lenInvSubTitle15) / 2;
            int xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            int xInvSubTitle3 = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2;

            // Draw Invoice Head:
            if (InvTitle != "")
            {
                CurrentY = CurrentY + ImageHeight;
                g.DrawString(InvTitle, InvTitleFont, BlueBrush, xInvTitle, CurrentY);
            }
            if (InvSubTitle1 != "")
            {
                CurrentY = CurrentY + InvTitleHeight;
                g.DrawString(InvSubTitle1, InvSubTitleFont, BlueBrush, xInvSubTitle1, CurrentY);
            }
            if (InvSubTitle15 != "")
            {
                CurrentY = CurrentY + InvTitleHeight;
                g.DrawString(InvSubTitle15, InvSubTitleFont, BlueBrush, xInvSubTitle15, CurrentY);
            }
            if (InvSubTitle2 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2, CurrentY);
            }
            if (InvSubTitle3 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle3, InvSubTitleFont, BlueBrush, xInvSubTitle3, CurrentY);
            }

            // Draw line:
            CurrentY = CurrentY + InvSubTitleHeight + 8;
            g.DrawLine(new Pen(Brushes.Black, 2), CurrentX, CurrentY, rightMargin, CurrentY);
        }
        private void SetPointStudent(Graphics g)
        {
            // Set Invoice Table:
            string FieldValue = "";

            // Set Table Head:
            int xProductID = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("MSSV", InvoiceFont, BlueBrush, xProductID, CurrentY);

            int xName = xProductID + (int)g.MeasureString("Product ID", InvoiceFont).Width + 70;
            g.DrawString("TenSV", InvoiceFont, BlueBrush, xName, CurrentY);

            int xProductName = xProductID + (int)g.MeasureString("Product ID", InvoiceFont).Width + 170;
            g.DrawString("Point", InvoiceFont, BlueBrush, xProductName, CurrentY);



         
            CurrentY = CurrentY + InvoiceFontHeight + 20;

            for (int i = 0; i < dgvBaiNop.RowCount; i++)
            {
                FieldValue = dgvBaiNop[0, i].Value.ToString();
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductID, CurrentY);

                FieldValue = db.SinhViens.Find(FieldValue).TEN.ToString();
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xName, CurrentY);

                FieldValue = Int64.Parse(dgvBaiNop[1, i].Value.ToString()).ToString() +".00";
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductName, CurrentY);


                CurrentY = CurrentY + 15;
            }
       

       

        }


        private void prnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            leftMargin = (int)e.MarginBounds.Left;
            rightMargin = (int)e.MarginBounds.Right;
            topMargin = (int)e.MarginBounds.Top;
            bottomMargin = (int)e.MarginBounds.Bottom;
            InvoiceWidth = (int)e.MarginBounds.Width;
            InvoiceHeight = (int)e.MarginBounds.Height;
            SetInvoiceHead(e.Graphics); // Draw Invoice Head
            SetPointStudent(e.Graphics); // Draw Point Student

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                prnDocument.Print();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }


    }
}
