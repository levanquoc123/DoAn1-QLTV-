using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quản_lý_thư_viện.BSlayer;
using System.Data.SqlClient;
using quản_lý_thư_viện.DBlayer;

namespace quản_lý_thư_viện
{
    public partial class taotaikhoanuser : Form
    {
        DataTable qldocgia = null;
        BLquanlydocgia BLQLDG = new BLquanlydocgia();

        DataTable dtTaotaikhoan = null;         // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        string err;
        BLtaotaikhoanuser dbTTKUser = new BLtaotaikhoanuser();
        public taotaikhoanuser()
        {
            InitializeComponent();
        }

        private void taotaikhoanuser_Load(object sender, EventArgs e)
        {
            tentaikhoan.Enabled = false;
            matkhau.Enabled = false;
            xemmatkhau.Enabled = false;
            luu.Enabled = false;
            textBox1.Text = tangmatudong();
            textBox1.Hide();
        }
        //thêm
        private void them_Click(object sender, EventArgs e)
        {
            Them = true;
            tentaikhoan.Enabled = true;
            matkhau.Enabled = true;
            xemmatkhau.Enabled = true;
            tentaikhoan.ResetText();
            matkhau.ResetText();
            tentaikhoan.Focus();
            luu.Enabled = true;
            huy.Enabled = true;
        }
        //hủy
        private void huy_Click(object sender, EventArgs e)
        {


            tentaikhoan.ResetText();
            matkhau.ResetText();
            tentaikhoan.Enabled = false;
            matkhau.Enabled = false;
            xemmatkhau.Enabled = false;
            tentaikhoan.Focus();
            quyenmacdinh.Enabled = false;
            luu.Enabled = false;
            huy.Enabled = true;
        }
        //thoát
        private void quaylai_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
                //Application.Exit();
                this.Close();
        }
        //kiểm tra tài khoản có bị trùng ko
        private bool kiemtratontai()
        {
            BLtaotaikhoanuser kttk = new BLtaotaikhoanuser();
            bool tatkt = false;
            string tk = tentaikhoan.Text;
            if (kttk.KiemTraNguoiDung(tk) == true)
            {
                tatkt = true;
            }
            return tatkt;
        }
        string tsest = "Chưa có";
        string b = "0";

        //lưu
        private void luu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                if (kiemtratontai())
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại !");
                }
                else
                {
                    try
                    {
                        // Thực hiện lệnh                     
                        BLtaotaikhoanuser dbTTKUser = new BLtaotaikhoanuser();

                        dbTTKUser.ThemNguoiDung(this.tentaikhoan.Text, this.matkhau.Text, this.quyenmacdinh.Text, ref err);
                        BLQLDG.ThemDocGia(this.textBox1.Text, this.tentaikhoan.Text, this.tsest, this.tsest, b, ref err);

                        // Thông báo                  
                        MessageBox.Show("Đã thêm xong!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
            }

        }
        //hàm tăng mã tự động
        public string tangmatudong()
        {
            qldocgia = new DataTable();
            qldocgia.Clear();
            DataSet ds = BLQLDG.LayDocGia();
            qldocgia = ds.Tables[0];
            string ma = "";
            if (ds.Tables[0].Rows.Count <= 0)
            {
                ma = "DG001";
            }
            else
            {
                int k;
                ma = "DG";
                k = Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";

                }
                else if (k < 100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }

        private void xemmatkhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (xemmatkhau.Checked == true)
            {
                matkhau.UseSystemPasswordChar = true;
            }
            else
                matkhau.UseSystemPasswordChar = false;
        }
    }
}