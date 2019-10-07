namespace quản_lý_thư_viện
{
    partial class taotaikhoanuser
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.luu = new System.Windows.Forms.Button();
            this.quyenmacdinh = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.tentaikhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quaylai = new System.Windows.Forms.Button();
            this.huy = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.xemmatkhau = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // luu
            // 
            this.luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luu.Location = new System.Drawing.Point(144, 305);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 37);
            this.luu.TabIndex = 29;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // quyenmacdinh
            // 
            this.quyenmacdinh.Enabled = false;
            this.quyenmacdinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quyenmacdinh.Location = new System.Drawing.Point(206, 240);
            this.quyenmacdinh.Multiline = true;
            this.quyenmacdinh.Name = "quyenmacdinh";
            this.quyenmacdinh.Size = new System.Drawing.Size(45, 25);
            this.quyenmacdinh.TabIndex = 28;
            this.quyenmacdinh.Text = "user";
            // 
            // matkhau
            // 
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(206, 178);
            this.matkhau.Multiline = true;
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.Size = new System.Drawing.Size(160, 25);
            this.matkhau.TabIndex = 27;
            // 
            // tentaikhoan
            // 
            this.tentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tentaikhoan.Location = new System.Drawing.Point(206, 102);
            this.tentaikhoan.Multiline = true;
            this.tentaikhoan.Name = "tentaikhoan";
            this.tentaikhoan.Size = new System.Drawing.Size(160, 25);
            this.tentaikhoan.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Quyền ";
            // 
            // quaylai
            // 
            this.quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quaylai.Location = new System.Drawing.Point(416, 305);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(119, 37);
            this.quaylai.TabIndex = 24;
            this.quaylai.Text = "Quay Lại";
            this.quaylai.UseVisualStyleBackColor = true;
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // huy
            // 
            this.huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huy.Location = new System.Drawing.Point(281, 305);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(75, 37);
            this.huy.TabIndex = 23;
            this.huy.Text = "Hủy";
            this.huy.UseVisualStyleBackColor = true;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(5, 305);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 37);
            this.them.TabIndex = 22;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "TẠO TÀI KHOẢN ";
            // 
            // xemmatkhau
            // 
            this.xemmatkhau.AutoSize = true;
            this.xemmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.xemmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemmatkhau.Location = new System.Drawing.Point(390, 183);
            this.xemmatkhau.Name = "xemmatkhau";
            this.xemmatkhau.Size = new System.Drawing.Size(145, 24);
            this.xemmatkhau.TabIndex = 20;
            this.xemmatkhau.Text = "&Xem Mật Khẩu";
            this.xemmatkhau.UseVisualStyleBackColor = false;
            this.xemmatkhau.CheckedChanged += new System.EventHandler(this.xemmatkhau_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // taotaikhoanuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 359);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.quyenmacdinh);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.tentaikhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.huy);
            this.Controls.Add(this.them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xemmatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "taotaikhoanuser";
            this.Text = "taotaikhoanuser";
            this.Load += new System.EventHandler(this.taotaikhoanuser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.TextBox quyenmacdinh;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.TextBox tentaikhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.Button huy;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox xemmatkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}