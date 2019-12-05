namespace QLDeThi
{
    partial class FormMenuCS
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
            this.btnNhapMonHoc = new System.Windows.Forms.Button();
            this.btnNhapKhoa = new System.Windows.Forms.Button();
            this.btnNhapLop = new System.Windows.Forms.Button();
            this.btnNhapSinhVien = new System.Windows.Forms.Button();
            this.btnNhapGiangVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhapMonHoc
            // 
            this.btnNhapMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapMonHoc.Location = new System.Drawing.Point(0, 0);
            this.btnNhapMonHoc.Name = "btnNhapMonHoc";
            this.btnNhapMonHoc.Size = new System.Drawing.Size(138, 121);
            this.btnNhapMonHoc.TabIndex = 0;
            this.btnNhapMonHoc.Text = "Mon Hoc";
            this.btnNhapMonHoc.UseVisualStyleBackColor = true;
            this.btnNhapMonHoc.Click += new System.EventHandler(this.btnNhapMonHoc_Click);
            // 
            // btnNhapKhoa
            // 
            this.btnNhapKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKhoa.Location = new System.Drawing.Point(133, 0);
            this.btnNhapKhoa.Name = "btnNhapKhoa";
            this.btnNhapKhoa.Size = new System.Drawing.Size(138, 121);
            this.btnNhapKhoa.TabIndex = 0;
            this.btnNhapKhoa.Text = "Khoa";
            this.btnNhapKhoa.UseVisualStyleBackColor = true;
            this.btnNhapKhoa.Click += new System.EventHandler(this.btnNhapKhoa_Click);
            // 
            // btnNhapLop
            // 
            this.btnNhapLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLop.Location = new System.Drawing.Point(267, 0);
            this.btnNhapLop.Name = "btnNhapLop";
            this.btnNhapLop.Size = new System.Drawing.Size(138, 121);
            this.btnNhapLop.TabIndex = 0;
            this.btnNhapLop.Text = "Lop";
            this.btnNhapLop.UseVisualStyleBackColor = true;
            this.btnNhapLop.Click += new System.EventHandler(this.btnNhapLop_Click);
            // 
            // btnNhapSinhVien
            // 
            this.btnNhapSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSinhVien.Location = new System.Drawing.Point(400, 0);
            this.btnNhapSinhVien.Name = "btnNhapSinhVien";
            this.btnNhapSinhVien.Size = new System.Drawing.Size(138, 121);
            this.btnNhapSinhVien.TabIndex = 0;
            this.btnNhapSinhVien.Text = "Sinh Vien";
            this.btnNhapSinhVien.UseVisualStyleBackColor = true;
            this.btnNhapSinhVien.Click += new System.EventHandler(this.btnNhapSinhVien_Click);
            // 
            // btnNhapGiangVien
            // 
            this.btnNhapGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapGiangVien.Location = new System.Drawing.Point(532, 0);
            this.btnNhapGiangVien.Name = "btnNhapGiangVien";
            this.btnNhapGiangVien.Size = new System.Drawing.Size(138, 121);
            this.btnNhapGiangVien.TabIndex = 0;
            this.btnNhapGiangVien.Text = "GiangVien";
            this.btnNhapGiangVien.UseVisualStyleBackColor = true;
            this.btnNhapGiangVien.Click += new System.EventHandler(this.btnNhapGiangVien_Click);
            // 
            // FormMenuCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 120);
            this.Controls.Add(this.btnNhapGiangVien);
            this.Controls.Add(this.btnNhapSinhVien);
            this.Controls.Add(this.btnNhapLop);
            this.Controls.Add(this.btnNhapKhoa);
            this.Controls.Add(this.btnNhapMonHoc);
            this.Name = "FormMenuCS";
            this.Text = "FormMenuCS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhapMonHoc;
        private System.Windows.Forms.Button btnNhapKhoa;
        private System.Windows.Forms.Button btnNhapLop;
        private System.Windows.Forms.Button btnNhapSinhVien;
        private System.Windows.Forms.Button btnNhapGiangVien;
    }
}