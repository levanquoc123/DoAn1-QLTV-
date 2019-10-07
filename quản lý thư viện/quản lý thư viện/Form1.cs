using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_thư_viện
{
    public partial class Form1 : Form
    {
        public static bool tinhtrang = false;//Biến tĩnh ghi nhận tình trạng đăng nhập 
        string nduser = "user";
        string ndadmin = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        //mở form đăng nhập
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.xuathienten.ResetText();
            dangnhap dn = new dangnhap();
            dn.ShowDialog();
            if (Form1.tinhtrang == true)
            {
                this.label11.Show();
                this.xuathienten.Show();
                this.đăngNhậpToolStripMenuItem.Enabled = false;
                xuathienten.Text = dangnhap.tenhienthi;
                this.chứcNăngToolStripMenuItem.Enabled = true;
                if (nduser == dangnhap.quyendangnhap)
                {
                    this.liênHệToolStripMenuItem.Enabled = true;
                    this.adminToolStripMenuItem.Enabled = false;
                    this.userToolStripMenuItem.Enabled = true;
                    this.chỉnhSửaThôngTinUserToolStripMenuItem.Enabled = true;
                }
                else if (ndadmin == dangnhap.quyendangnhap)
                {
                    this.liênHệToolStripMenuItem.Enabled = false;
                    this.userToolStripMenuItem.Enabled = false;
                    this.adminToolStripMenuItem.Enabled = true;
                    this.chỉnhSửaThôngTinUserToolStripMenuItem.Enabled = false;
                }
            }
        }

        //thoát
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tinhtrang == true)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    this.Show();
                    this.đăngNhậpToolStripMenuItem.Enabled = true;
                    this.xuathienten.ResetText();
                    this.label11.Hide();
                    this.xuathienten.Hide();
                    this.chứcNăngToolStripMenuItem.Enabled = false;
                }
                tinhtrang = false;
            }
            else if (tinhtrang == false)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                    Application.Exit();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.label11.Hide();
            this.xuathienten.Hide();
            this.chứcNăngToolStripMenuItem.Enabled = false;
        }

        //hiển thị form admin
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.ShowDialog();
        }
        //hiển thị form user
       
        //hiển thị form yeucau
        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeucauht ycht = new yeucauht();
            ycht.ShowDialog();

        }
        //hiển thị form chỉnh sửa user
        private void chỉnhSửaThôngTinUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chinhsuathongtinnguoidung cs = new chinhsuathongtinnguoidung();
            cs.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muonsach ms = new muonsach();
            //ms.ShowDialog();
            muonsach cms = new muonsach();
            cms.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
