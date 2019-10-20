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
    public partial class quanlyadmin : Form
    {
        DataTable dtqladmin = null;         // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        bool Sua;
        string err;
        BLtaotaikhoanuser BLQLAdmin = new BLtaotaikhoanuser();
        string quyenhan = "admin";
        public quanlyadmin()
        {
            InitializeComponent();
        }

        private void quanlyadmin_Load(object sender, EventArgs e)
        {
            LoadData();
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            chaychu.Location = new Point(chaychu.Location.X + 1, chaychu.Location.Y);
            if (chaychu.Location.X > this.Width || chaychu.Location.X <= 0)
            {
                chaychu.Location = new Point(chaychu.Location.X - this.Width, chaychu.Location.Y);
            }
        }
        //lấy dữ liệu với quyền là admin
        public void LoadData()
        {
            try
            {
                dtqladmin = new DataTable();
                dtqladmin.Clear();
                DataSet ds = BLQLAdmin.LayNguoiDungAdmin(quyenhan);
                dtqladmin = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView                          
                dataGridView1.DataSource = dtqladmin;
                panel1.Enabled = false;
                Them = false;
                Sua = false;
                tk.ResetText();
                mk.ResetText();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table taikhoan. Lỗi rồi!!!");
            }
        }

        //tải lại dữ liệu
        private void reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void them_Click(object sender, EventArgs e)
        {
            Them = true;
            panel1.Enabled = true;
            tk.Enabled = true;
            tk.Focus();
        }

        //xóa
        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành          
                string strHoaDon = dataGridView1.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp              
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?      
                if (traloi == DialogResult.Yes)
                {

                    BLQLAdmin.XoaNguoiDung(ref err, strHoaDon);

                    // Cập nhật lại DataGridView        
                    LoadData();
                    // Thông báo                    
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo         
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        //sửa 
        private void sua_Click(object sender, EventArgs e)
        {
            Sua = true;
            panel1.Enabled = true;
            tk.Enabled = false;
            mk.Focus();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel         
            tk.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            mk.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();


        }

        //lưu
        private void button2_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                try
                {
                    // Thực hiện lệnh                     

                    BLQLAdmin.ThemNguoiDung(this.tk.Text, this.mk.Text, this.quyenhan, ref err);
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
            if (Sua == true)
            {
                BLtaotaikhoanuser BLQLAdmin1 = new BLtaotaikhoanuser();
                BLQLAdmin1.CapNhatNguoiDung(this.tk.Text, this.mk.Text, ref err);
                //, this.quyenhan,

                // Load lại dữ liệu trên DataGridView           
                LoadData();
                // Thông báo            
                MessageBox.Show("Đã sửa xong!");
            }
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
        //tìm kiếm
        private void button1_Click(object sender, EventArgs e)
        {
            dtqladmin = new DataTable();
            dtqladmin.Clear();
            DataSet ds = BLQLAdmin.LayTenNguoiDung(this.tencantim.Text);
            dtqladmin = ds.Tables[0];
            // Đưa dữ liệu lên DataGridView                          
            dataGridView1.DataSource = dtqladmin;
        }

    }
}
