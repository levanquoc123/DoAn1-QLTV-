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
        public static bool tinhtrang = false;
        string nduser = "user";
        string ndadmin = "admin";
        public Form1()
        {
            InitializeComponent();
        }

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
                label5.Text = dangnhap.tenhienthi;
                this.chứcNăngToolStripMenuItem1.Enabled = true;
                if (nduser == dangnhap.quyendangnhap)
                {
                    this.liênHệToolStripMenuItem.Enabled = true;
                    this.adminToolStripMenuItem1.Visible = false;
                    this.userToolStripMenuItem1.Enabled = true;
                    this.chỉnhSửaToolStripMenuItem.Visible = true;
                }
                else if (ndadmin == dangnhap.quyendangnhap)
                {
                    this.hỗTrợToolStripMenuItem.Enabled = false;
                    this.userToolStripMenuItem1.Visible = false;
                    this.adminToolStripMenuItem1.Visible = true;
                    this.chỉnhSửaToolStripMenuItem.Visible = false;
                }
            }
        }     
        private void Form1_Load(object sender, EventArgs e)
        {
            this.label11.Hide();
            this.xuathienten.Hide();
            this.chứcNăngToolStripMenuItem1.Enabled = false;
        }
        private void liToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeucauht ycht = new yeucauht();
            ycht.ShowDialog();

        }      
        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chinhsuathongtinnguoidung cs = new chinhsuathongtinnguoidung();
            cs.ShowDialog();
        }
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
                    this.chứcNăngToolStripMenuItem1.Enabled = false;
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
        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.ShowDialog();
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muonsach cms = new muonsach();
            cms.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
