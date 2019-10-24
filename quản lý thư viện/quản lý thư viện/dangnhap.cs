using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using quản_lý_thư_viện.DBlayer;
using quản_lý_thư_viện.BSlayer;
namespace quản_lý_thư_viện
{
    public partial class dangnhap : Form
    {
        public static string tenhienthi = "";
        public static string quyendangnhap = "";
        public dangnhap()
        {
            InitializeComponent();
        }
        private void xemmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (xemmatkhau.Checked == true)
            {
                matkhau.UseSystemPasswordChar = true;
            }
            else
                matkhau.UseSystemPasswordChar = false;
        }
        private void thoat_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
                this.Close();
        }
        private void taotaikhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            taotaikhoanuser taotk = new taotaikhoanuser();
            taotk.ShowDialog();
            this.Show();
        }
        private void dangnhap_Load(object sender, EventArgs e)
        {
           
        }
        private void dangnhapnd_Click(object sender, EventArgs e)
        {
            BLkiemtratk kttk = new BLkiemtratk();
            try
            {

                string tk = taikhoan.Text;
                string mk = matkhau.Text;
                string quyendn = comboBox1.Text;
                if (kttk.ktratk(tk, mk, quyendn) == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "TRẠNG THÁI ĐĂNG NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tenhienthi = taikhoan.Text;
                    quyendangnhap = comboBox1.Text;
                    Form1.tinhtrang = true;
                    
                    Close();
                }
                else
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu bị sai!!!", "TRẠNG THÁI ĐĂNG NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
