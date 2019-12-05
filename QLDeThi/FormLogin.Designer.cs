namespace QLDeThi
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbnCS1 = new System.Windows.Forms.RadioButton();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.rbnCS2 = new System.Windows.Forms.RadioButton();
            this.rbnTruong = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGvPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGV = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.asdas = new System.Windows.Forms.Label();
            this.txtRegisterRePass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegisterPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSvPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // rbnCS1
            // 
            this.rbnCS1.AutoSize = true;
            this.rbnCS1.Location = new System.Drawing.Point(20, 19);
            this.rbnCS1.Name = "rbnCS1";
            this.rbnCS1.Size = new System.Drawing.Size(45, 17);
            this.rbnCS1.TabIndex = 2;
            this.rbnCS1.Text = "CS1";
            this.rbnCS1.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(164, 39);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Login";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // rbnCS2
            // 
            this.rbnCS2.AutoSize = true;
            this.rbnCS2.Location = new System.Drawing.Point(20, 42);
            this.rbnCS2.Name = "rbnCS2";
            this.rbnCS2.Size = new System.Drawing.Size(45, 17);
            this.rbnCS2.TabIndex = 2;
            this.rbnCS2.Text = "CS2";
            this.rbnCS2.UseVisualStyleBackColor = true;
            // 
            // rbnTruong
            // 
            this.rbnTruong.AutoSize = true;
            this.rbnTruong.Checked = true;
            this.rbnTruong.Location = new System.Drawing.Point(20, 65);
            this.rbnTruong.Name = "rbnTruong";
            this.rbnTruong.Size = new System.Drawing.Size(59, 17);
            this.rbnTruong.TabIndex = 2;
            this.rbnTruong.TabStop = true;
            this.rbnTruong.Text = "Trường";
            this.rbnTruong.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnCS1);
            this.groupBox1.Controls.Add(this.rbnCS2);
            this.groupBox1.Controls.Add(this.rbnTruong);
            this.groupBox1.Controls.Add(this.btnAdmin);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMGV);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtGvPass);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnGV);
            this.groupBox3.Location = new System.Drawing.Point(336, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 113);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giảng Viên";
            // 
            // txtMGV
            // 
            this.txtMGV.Location = new System.Drawing.Point(62, 19);
            this.txtMGV.Name = "txtMGV";
            this.txtMGV.Size = new System.Drawing.Size(132, 20);
            this.txtMGV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MGV";
            // 
            // txtGvPass
            // 
            this.txtGvPass.Location = new System.Drawing.Point(62, 59);
            this.txtGvPass.Name = "txtGvPass";
            this.txtGvPass.PasswordChar = '*';
            this.txtGvPass.Size = new System.Drawing.Size(132, 20);
            this.txtGvPass.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pass";
            // 
            // btnGV
            // 
            this.btnGV.Location = new System.Drawing.Point(80, 84);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(75, 23);
            this.btnGV.TabIndex = 3;
            this.btnGV.Text = "Login";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtId);
            this.groupBox4.Controls.Add(this.asdas);
            this.groupBox4.Controls.Add(this.txtRegisterRePass);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtRegisterPass);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnRegister);
            this.groupBox4.Location = new System.Drawing.Point(12, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 131);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Register";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(62, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 20);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // asdas
            // 
            this.asdas.AutoSize = true;
            this.asdas.Location = new System.Drawing.Point(16, 26);
            this.asdas.Name = "asdas";
            this.asdas.Size = new System.Drawing.Size(18, 13);
            this.asdas.TabIndex = 4;
            this.asdas.Text = "ID";
            // 
            // txtRegisterRePass
            // 
            this.txtRegisterRePass.Location = new System.Drawing.Point(62, 102);
            this.txtRegisterRePass.Name = "txtRegisterRePass";
            this.txtRegisterRePass.PasswordChar = '*';
            this.txtRegisterRePass.Size = new System.Drawing.Size(132, 20);
            this.txtRegisterRePass.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Re-Pass";
            // 
            // txtRegisterPass
            // 
            this.txtRegisterPass.Location = new System.Drawing.Point(62, 59);
            this.txtRegisterPass.Name = "txtRegisterPass";
            this.txtRegisterPass.PasswordChar = '*';
            this.txtRegisterPass.Size = new System.Drawing.Size(132, 20);
            this.txtRegisterPass.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Pass";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(207, 53);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 44);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSV
            // 
            this.btnSV.Location = new System.Drawing.Point(74, 85);
            this.btnSV.Name = "btnSV";
            this.btnSV.Size = new System.Drawing.Size(75, 23);
            this.btnSV.TabIndex = 3;
            this.btnSV.Text = "Login";
            this.btnSV.UseVisualStyleBackColor = true;
            this.btnSV.Click += new System.EventHandler(this.btnSV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pass";
            // 
            // txtSvPass
            // 
            this.txtSvPass.Location = new System.Drawing.Point(62, 59);
            this.txtSvPass.Name = "txtSvPass";
            this.txtSvPass.PasswordChar = '*';
            this.txtSvPass.Size = new System.Drawing.Size(132, 20);
            this.txtSvPass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(62, 19);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(132, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMSSV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSvPass);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSV);
            this.groupBox2.Location = new System.Drawing.Point(336, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sinh Viên";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 305);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbnCS1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.RadioButton rbnCS2;
        private System.Windows.Forms.RadioButton rbnTruong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGvPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label asdas;
        private System.Windows.Forms.TextBox txtRegisterRePass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRegisterPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSvPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}