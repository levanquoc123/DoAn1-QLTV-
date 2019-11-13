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

namespace quản_lý_thư_viện
{
    public partial class themsach : Form
    {
        DataTable qlsach = null;         // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        //bool Them;
        string err;
        BLquanlysach dbQLS = new BLquanlysach();
        BLtacgia dbQLTG = new BLtacgia();
        BLnxb dbQLNXB = new BLnxb();

        public themsach()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            chaychu.Location = new Point(chaychu.Location.X + 1, chaychu.Location.Y);
            if (chaychu.Location.X > this.Width || chaychu.Location.X <= 0)
            {
                chaychu.Location = new Point(chaychu.Location.X - this.Width, chaychu.Location.Y);
            }
        }

        private void themsach_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        //lấy dữ liệu sách
        public void LoadData()
        {
            try
            {
                qlsach = new DataTable();
                qlsach.Clear();
                DataSet ds = dbQLS.LaySach();
                qlsach = ds.Tables[0];
               
                // Đưa dữ liệu lên DataGridView       
                themmasach.Text = tangmatudong();
                // Thay đổi độ rộng cột    
                chonmanxb.DataSource = qlsach;
                chonmanxb.DisplayMember = "manxb";
                this.themmasach.Enabled = false;

            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table cuonsach. Lỗi rồi!!!");
            }
        }
        //thêm
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Thực hiện lệnh                     

                dbQLS.ThemSach(this.themmasach.Text, this.themtuade.Text, this.themtheloai.Text, this.chonmanxb.Text, this.themsoluong.Text, this.themvitri.Text, ref err);
                dbQLTG.ThemTacGia(this.themmasach.Text, this.themtentacgia.Text, ref err);
                dbQLNXB.ThemNXB(this.chonmanxb.Text, this.themtennxb.Text, this.themdiachi.Text, this.themsdt.Text, ref err);
                // Load lại dữ liệu trên DataGridView             
                LoadData();
                // Thông báo                  
                MessageBox.Show("Đã thêm xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }
        //hủy
        private void huy_Click(object sender, EventArgs e)
        {
            themmasach.ResetText();
            themtuade.ResetText();
            themtheloai.ResetText();
            chonmanxb.ResetText();
            chonmanxb.Text = "Chọn Mã NXB";
            themsoluong.ResetText();
            themvitri.ResetText();
        }
        //thoát
        private void quaylai_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
                this.Close();
        }

        //tăng mã tự động
        public string tangmatudong()
        {
            qlsach = new DataTable();
            qlsach.Clear();
            DataSet ds = dbQLS.LaySach();
            qlsach = ds.Tables[0];
            string ma = "";
            if (ds.Tables[0].Rows.Count <= 0)
            {
                ma = "MS001";
            }
            else
            {
                int k;
                ma = "MS";
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

      
    }
}
