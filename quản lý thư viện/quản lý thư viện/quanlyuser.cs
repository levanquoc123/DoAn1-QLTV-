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
    public partial class quanlyuser : Form
    {
        DataTable dtqluser = null;         // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Sua;
        string err;
        BLtaotaikhoanuser BLQLUser = new BLtaotaikhoanuser();
        string quyenhan = "user";
        public quanlyuser()
        {
            InitializeComponent();
        }

        private void quanlyuser_Load(object sender, EventArgs e)
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
        //tải lại
        private void reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //lấy dữ liệu với quyền user
        public void LoadData()
        {
            try
            {
                dtqluser = new DataTable();
                dtqluser.Clear();
                DataSet ds = BLQLUser.LayNguoiDungUser(quyenhan);
                dtqluser = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView                          
                dataGridView1.DataSource = dtqluser;
                panel1.Enabled = false;
                mk.ResetText();
                Sua = false;
                tk.ResetText();

            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table taikhoan. Lỗi rồi!!!");
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
        //sửa
        private void button1_Click(object sender, EventArgs e)
        {
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
        //xóa
        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh             
                // Lấy thứ tự record hiện hành              

                int r = dataGridView1.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành          
                string strHoaDon = dataGridView1.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  

                // Hiện thông báo xác nhận việc xóa mẫu tin         
                // Khai báo biến traloi                 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp              
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?      
                if (traloi == DialogResult.Yes)
                {

                    BLQLUser.XoaNguoiDung(ref err, strHoaDon);

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
        private void button2_Click(object sender, EventArgs e)
        {
            dtqluser = new DataTable();
            dtqluser.Clear();
            DataSet ds = BLQLUser.LayTenNguoiDung(this.tencantim.Text);
            dtqluser = ds.Tables[0];
            // Đưa dữ liệu lên DataGridView                          
            dataGridView1.DataSource = dtqluser;
        }

        private void tencantim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            chitietsachchomuon ctscm = new chitietsachchomuon();
            ctscm.hienthimadocgia.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ctscm.ShowDialog();
        }

    }
}
