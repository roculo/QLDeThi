namespace QLDeThi
{
    partial class FormLamBaiThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvCauHoi = new System.Windows.Forms.DataGridView();
            this.lbMonThi = new System.Windows.Forms.Label();
            this.lbMaMH = new System.Windows.Forms.Label();
            this.lbLan = new System.Windows.Forms.Label();
            this.lbTrinh = new System.Windows.Forms.Label();
            this.lbNgayThi = new System.Windows.Forms.Label();
            this.lbSTT = new System.Windows.Forms.Label();
            this.lbNoiDung = new System.Windows.Forms.Label();
            this.rbnA = new System.Windows.Forms.RadioButton();
            this.rbnB = new System.Windows.Forms.RadioButton();
            this.rbnC = new System.Windows.Forms.RadioButton();
            this.rbnD = new System.Windows.Forms.RadioButton();
            this.btnNop = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCauHoi
            // 
            this.dgvCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoi.Location = new System.Drawing.Point(12, 72);
            this.dgvCauHoi.Name = "dgvCauHoi";
            this.dgvCauHoi.Size = new System.Drawing.Size(73, 353);
            this.dgvCauHoi.TabIndex = 0;
            this.dgvCauHoi.SelectionChanged += new System.EventHandler(this.dgvCauHoi_SelectionChanged);
            // 
            // lbMonThi
            // 
            this.lbMonThi.AutoSize = true;
            this.lbMonThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonThi.Location = new System.Drawing.Point(95, 9);
            this.lbMonThi.Name = "lbMonThi";
            this.lbMonThi.Size = new System.Drawing.Size(90, 25);
            this.lbMonThi.TabIndex = 1;
            this.lbMonThi.Text = "MonThi";
            // 
            // lbMaMH
            // 
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaMH.Location = new System.Drawing.Point(325, 9);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(79, 25);
            this.lbMaMH.TabIndex = 1;
            this.lbMaMH.Text = "MaMH";
            // 
            // lbLan
            // 
            this.lbLan.AutoSize = true;
            this.lbLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLan.Location = new System.Drawing.Point(530, 9);
            this.lbLan.Name = "lbLan";
            this.lbLan.Size = new System.Drawing.Size(51, 25);
            this.lbLan.TabIndex = 1;
            this.lbLan.Text = "Lần";
            // 
            // lbTrinh
            // 
            this.lbTrinh.AutoSize = true;
            this.lbTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrinh.Location = new System.Drawing.Point(714, 9);
            this.lbTrinh.Name = "lbTrinh";
            this.lbTrinh.Size = new System.Drawing.Size(66, 25);
            this.lbTrinh.TabIndex = 1;
            this.lbTrinh.Text = "Trình";
            // 
            // lbNgayThi
            // 
            this.lbNgayThi.AutoSize = true;
            this.lbNgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThi.Location = new System.Drawing.Point(312, 47);
            this.lbNgayThi.Name = "lbNgayThi";
            this.lbNgayThi.Size = new System.Drawing.Size(45, 20);
            this.lbNgayThi.TabIndex = 1;
            this.lbNgayThi.Text = "Ngày";
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.Location = new System.Drawing.Point(192, 98);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(78, 13);
            this.lbSTT.TabIndex = 2;
            this.lbSTT.Text = "Số TT Câu Hỏi";
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AutoSize = true;
            this.lbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung.Location = new System.Drawing.Point(192, 128);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(75, 20);
            this.lbNoiDung.TabIndex = 2;
            this.lbNoiDung.Text = "Nội Dung";
            // 
            // rbnA
            // 
            this.rbnA.AutoSize = true;
            this.rbnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnA.Location = new System.Drawing.Point(196, 165);
            this.rbnA.Name = "rbnA";
            this.rbnA.Size = new System.Drawing.Size(35, 22);
            this.rbnA.TabIndex = 3;
            this.rbnA.TabStop = true;
            this.rbnA.Text = "A";
            this.rbnA.UseVisualStyleBackColor = true;
            this.rbnA.CheckedChanged += new System.EventHandler(this.rbnA_CheckedChanged);
            // 
            // rbnB
            // 
            this.rbnB.AutoSize = true;
            this.rbnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnB.Location = new System.Drawing.Point(196, 214);
            this.rbnB.Name = "rbnB";
            this.rbnB.Size = new System.Drawing.Size(36, 22);
            this.rbnB.TabIndex = 3;
            this.rbnB.TabStop = true;
            this.rbnB.Text = "B";
            this.rbnB.UseVisualStyleBackColor = true;
            this.rbnB.CheckedChanged += new System.EventHandler(this.rbnB_CheckedChanged);
            // 
            // rbnC
            // 
            this.rbnC.AutoSize = true;
            this.rbnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnC.Location = new System.Drawing.Point(196, 270);
            this.rbnC.Name = "rbnC";
            this.rbnC.Size = new System.Drawing.Size(37, 22);
            this.rbnC.TabIndex = 3;
            this.rbnC.TabStop = true;
            this.rbnC.Text = "C";
            this.rbnC.UseVisualStyleBackColor = true;
            this.rbnC.CheckedChanged += new System.EventHandler(this.rbnC_CheckedChanged);
            // 
            // rbnD
            // 
            this.rbnD.AutoSize = true;
            this.rbnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnD.Location = new System.Drawing.Point(196, 327);
            this.rbnD.Name = "rbnD";
            this.rbnD.Size = new System.Drawing.Size(37, 22);
            this.rbnD.TabIndex = 3;
            this.rbnD.TabStop = true;
            this.rbnD.Text = "D";
            this.rbnD.UseVisualStyleBackColor = true;
            this.rbnD.CheckedChanged += new System.EventHandler(this.rbnD_CheckedChanged);
            // 
            // btnNop
            // 
            this.btnNop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNop.Location = new System.Drawing.Point(299, 438);
            this.btnNop.Name = "btnNop";
            this.btnNop.Size = new System.Drawing.Size(196, 56);
            this.btnNop.TabIndex = 4;
            this.btnNop.Text = "Nộp Bài";
            this.btnNop.UseVisualStyleBackColor = true;
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(547, 187);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(145, 55);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormLamBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 506);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnNop);
            this.Controls.Add(this.rbnD);
            this.Controls.Add(this.rbnC);
            this.Controls.Add(this.rbnB);
            this.Controls.Add(this.rbnA);
            this.Controls.Add(this.lbNoiDung);
            this.Controls.Add(this.lbSTT);
            this.Controls.Add(this.lbTrinh);
            this.Controls.Add(this.lbNgayThi);
            this.Controls.Add(this.lbLan);
            this.Controls.Add(this.lbMaMH);
            this.Controls.Add(this.lbMonThi);
            this.Controls.Add(this.dgvCauHoi);
            this.Name = "FormLamBaiThi";
            this.Text = "FormLamBaiThi";
            this.Load += new System.EventHandler(this.FormLamBaiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCauHoi;
        private System.Windows.Forms.Label lbMonThi;
        private System.Windows.Forms.Label lbMaMH;
        private System.Windows.Forms.Label lbLan;
        private System.Windows.Forms.Label lbTrinh;
        private System.Windows.Forms.Label lbNgayThi;
        private System.Windows.Forms.Label lbSTT;
        private System.Windows.Forms.Label lbNoiDung;
        private System.Windows.Forms.RadioButton rbnA;
        private System.Windows.Forms.RadioButton rbnB;
        private System.Windows.Forms.RadioButton rbnC;
        private System.Windows.Forms.RadioButton rbnD;
        private System.Windows.Forms.Button btnNop;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
    }
}