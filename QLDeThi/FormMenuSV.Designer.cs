namespace QLDeThi
{
    partial class FormMenuSV
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
            this.btnThi = new System.Windows.Forms.Button();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThi
            // 
            this.btnThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThi.Location = new System.Drawing.Point(0, 0);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(343, 287);
            this.btnThi.TabIndex = 0;
            this.btnThi.Text = "Thi";
            this.btnThi.UseVisualStyleBackColor = true;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKQ.Location = new System.Drawing.Point(339, 0);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(343, 287);
            this.btnXemKQ.TabIndex = 0;
            this.btnXemKQ.Text = "Xem KQ";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // FormMenuSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 289);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.btnThi);
            this.Name = "FormMenuSV";
            this.Text = "FormSinhVienMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.Button btnXemKQ;
    }
}