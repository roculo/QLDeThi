namespace QLDeThi
{
    partial class FormMenuGV
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
            this.btnDK = new System.Windows.Forms.Button();
            this.btnCauHoi = new System.Windows.Forms.Button();
            this.btnBaiNop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDK
            // 
            this.btnDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDK.Location = new System.Drawing.Point(-1, 1);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(283, 266);
            this.btnDK.TabIndex = 0;
            this.btnDK.Text = "Đăng Ký/Cập Nhật Đề Thi";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauHoi.Location = new System.Drawing.Point(278, 1);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.Size = new System.Drawing.Size(289, 266);
            this.btnCauHoi.TabIndex = 0;
            this.btnCauHoi.Text = "Hiệu Chỉnh Câu Hỏi";
            this.btnCauHoi.UseVisualStyleBackColor = true;
            this.btnCauHoi.Click += new System.EventHandler(this.btnCauHoi_Click);
            // 
            // btnBaiNop
            // 
            this.btnBaiNop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaiNop.Location = new System.Drawing.Point(560, 1);
            this.btnBaiNop.Name = "btnBaiNop";
            this.btnBaiNop.Size = new System.Drawing.Size(287, 266);
            this.btnBaiNop.TabIndex = 1;
            this.btnBaiNop.Text = "Xem Bài Nộp";
            this.btnBaiNop.UseVisualStyleBackColor = true;
            this.btnBaiNop.Click += new System.EventHandler(this.btnBaiNop_Click);
            // 
            // FormMenuGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 263);
            this.Controls.Add(this.btnBaiNop);
            this.Controls.Add(this.btnCauHoi);
            this.Controls.Add(this.btnDK);
            this.Name = "FormMenuGV";
            this.Text = "FormMenuGV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Button btnCauHoi;
        private System.Windows.Forms.Button btnBaiNop;
    }
}