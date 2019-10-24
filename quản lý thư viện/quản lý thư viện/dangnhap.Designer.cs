namespace quản_lý_thư_viện
{
    partial class dangnhap
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.thoat = new System.Windows.Forms.Button();
            this.dangnhapnd = new System.Windows.Forms.Button();
            this.taotaikhoan = new System.Windows.Forms.Button();
            this.xemmatkhau = new System.Windows.Forms.CheckBox();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Chọn quyền:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.comboBox1.Location = new System.Drawing.Point(286, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // matkhau
            // 
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(222, 156);
            this.matkhau.Multiline = true;
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.Size = new System.Drawing.Size(160, 25);
            this.matkhau.TabIndex = 24;
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thoat.Location = new System.Drawing.Point(430, 256);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(87, 34);
            this.thoat.TabIndex = 23;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // dangnhapnd
            // 
            this.dangnhapnd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dangnhapnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhapnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhapnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dangnhapnd.Location = new System.Drawing.Point(239, 256);
            this.dangnhapnd.Name = "dangnhapnd";
            this.dangnhapnd.Size = new System.Drawing.Size(143, 34);
            this.dangnhapnd.TabIndex = 22;
            this.dangnhapnd.Text = "Đăng Nhập";
            this.dangnhapnd.UseVisualStyleBackColor = false;
            this.dangnhapnd.Click += new System.EventHandler(this.dangnhapnd_Click);
            // 
            // taotaikhoan
            // 
            this.taotaikhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.taotaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taotaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taotaikhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taotaikhoan.Location = new System.Drawing.Point(30, 256);
            this.taotaikhoan.Name = "taotaikhoan";
            this.taotaikhoan.Size = new System.Drawing.Size(177, 34);
            this.taotaikhoan.TabIndex = 21;
            this.taotaikhoan.Text = "Tạo Tài Khoản";
            this.taotaikhoan.UseVisualStyleBackColor = false;
            this.taotaikhoan.Click += new System.EventHandler(this.taotaikhoan_Click);
            // 
            // xemmatkhau
            // 
            this.xemmatkhau.AutoSize = true;
            this.xemmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.xemmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemmatkhau.Location = new System.Drawing.Point(391, 164);
            this.xemmatkhau.Name = "xemmatkhau";
            this.xemmatkhau.Size = new System.Drawing.Size(145, 24);
            this.xemmatkhau.TabIndex = 20;
            this.xemmatkhau.Text = "&Xem Mật Khẩu";
            this.xemmatkhau.UseVisualStyleBackColor = false;
            this.xemmatkhau.CheckedChanged += new System.EventHandler(this.xemmatkhau_CheckedChanged);
            // 
            // taikhoan
            // 
            this.taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.Location = new System.Drawing.Point(222, 109);
            this.taikhoan.Multiline = true;
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(160, 29);
            this.taikhoan.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(78, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tài Khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(205, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 31);
            this.label4.TabIndex = 29;
            this.label4.Text = "Đăng Nhập";
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dangnhapnd);
            this.Controls.Add(this.taotaikhoan);
            this.Controls.Add(this.xemmatkhau);
            this.Controls.Add(this.taikhoan);
            this.Name = "dangnhap";
            this.Text = "dangnhap";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button dangnhapnd;
        private System.Windows.Forms.Button taotaikhoan;
        private System.Windows.Forms.CheckBox xemmatkhau;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}